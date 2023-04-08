using System.Collections.Generic;
using System.Linq;
using Lumina.Data.Files;

namespace Lumina.Models.Models
{
    public struct ShapeMesh {
        public uint MeshIndex;
        public (ushort BaseTriangleIndex, ushort ReplacedTriangleIndex)[] Values;

        public static IReadOnlyList< ShapeMesh > ConstructList( MdlFile file ) 
        {
            var ret = new ShapeMesh[file.ModelHeader.ShapeMeshCount];
            var idx = 0;
            foreach( var shapeMeshStruct in file.ShapeMeshes ) {
                var values = Enumerable.Range( (int)shapeMeshStruct.ShapeValueOffset, (int) shapeMeshStruct.ShapeValueCount )
                   .Select( i => (Offset: file.ShapeValues[ i ].BaseIndicesIndex, Value: file.ShapeValues[i].ReplacingVertexIndex))
                   .ToArray();
                ret[idx++] = new ShapeMesh {
                    MeshIndex = shapeMeshStruct.MeshIndexOffset,
                    Values = values,
                };
            }

            return ret;
        }
    }

    public class Shape {
        public string Name { get; private set; }
        public ShapeMesh[] Meshes { get; private set; }

        public Shape(Model model, Model.ModelLod lod, IReadOnlyList<ShapeMesh> shapeMeshes, int shapeIndex)
        {
            var currentShape = model.File.Shapes[ shapeIndex ];
            Name   = model.StringOffsetToStringMap[ (int) currentShape.StringOffset ];
            Meshes = new ShapeMesh[currentShape.ShapeMeshCount[ (int) lod ]];
            var end    = currentShape.ShapeMeshCount[(int)lod];
            var offset = currentShape.ShapeMeshStartIndex[(int)lod];
            for( var i = 0; i < end; ++i ) {
                Meshes[ i ] = shapeMeshes[i + offset];
            }
        }
    }
}