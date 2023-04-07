using System.Collections.Generic;
using System.Linq;
using Lumina.Data.Files;

namespace Lumina.Models.Models
{
    public struct ShapeMesh {
        public uint StartIndex;
        public (ushort Offset, ushort Value)[] Values;

        public static IReadOnlyList< ShapeMesh > ConstructList( MdlFile file ) {
            var ret = new ShapeMesh[file.ModelHeader.ShapeMeshCount];
            var idx = 0;
            foreach( var shapeMeshStruct in file.ShapeMeshes ) {
                var values = Enumerable.Range( (int)shapeMeshStruct.ShapeValueOffset, (int) shapeMeshStruct.ShapeValueCount )
                   .Select( i => (file.ShapeValues[ i ].Offset, file.ShapeValues[i].Value))
                   .ToArray();
                ret[idx++] = new ShapeMesh {
                    StartIndex = shapeMeshStruct.StartIndex,
                    Values = values,
                };
            }

            return ret;
        }
    }

    public class Shape {
        private const int NumShapeMeshArrays = 3;
        public string Name { get; private set; }
        public ShapeMesh[][] Meshes { get; private set; } = new ShapeMesh[NumShapeMeshArrays][];

        public Shape(Model model, IReadOnlyList<ShapeMesh> shapeMeshes, int shapeIndex)
        {
            var currentShape = model.File.Shapes[ shapeIndex ];
            Name   = model.StringOffsetToStringMap[ (int) currentShape.StringOffset ];
            for( var i = 0; i < NumShapeMeshArrays; ++i ) {
                Meshes[ i ] = new ShapeMesh[currentShape.ShapeMeshCount[ i ]];
                var end    = currentShape.ShapeMeshCount[ i ];
                var offset = currentShape.ShapeMeshStartIndex[ i ];
                for( var j = 0; j < end; ++j ) {
                    Meshes[ i ][ j ] = shapeMeshes[j + offset];
                }
            }
        }
    }
}