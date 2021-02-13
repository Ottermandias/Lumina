// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingRecordType", columnHash: 0x2c75ba5d )]
    public class FishingRecordType : ExcelRow
    {
        
        public LazyRow< Addon > Addon;
        public ushort RankBRequirement;
        public ushort RankARequirement;
        public ushort RankAARequirement;
        public ushort RankAAARequirement;
        public ushort Unknown5;
        public byte Unknown6;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Addon = new LazyRow< Addon >( lumina, parser.ReadColumn< int >( 0 ), language );
            RankBRequirement = parser.ReadColumn< ushort >( 1 );
            RankARequirement = parser.ReadColumn< ushort >( 2 );
            RankAARequirement = parser.ReadColumn< ushort >( 3 );
            RankAAARequirement = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}