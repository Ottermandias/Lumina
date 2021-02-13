// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelChara", columnHash: 0xc7ed51f9 )]
    public class ModelChara : ExcelRow
    {
        
        public byte Type;
        public ushort Model;
        public byte Base;
        public byte Variant;
        public ushort SEPack;
        public byte Unknown5;
        public bool Unknown6;
        public bool PapVariation;
        public byte Unknown8;
        public sbyte Unknown9;
        public bool Unknown10;
        public bool Unknown11;
        public bool Unknown12;
        public bool Unknown13;
        public bool Unknown14;
        public byte Unknown15;
        public bool Unknown16;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< byte >( 0 );
            Model = parser.ReadColumn< ushort >( 1 );
            Base = parser.ReadColumn< byte >( 2 );
            Variant = parser.ReadColumn< byte >( 3 );
            SEPack = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            PapVariation = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
        }
    }
}