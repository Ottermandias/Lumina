// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2RangeType", columnHash: 0xdcfd9eba )]
    public class SkyIsland2RangeType : ExcelRow
    {
        
        public byte Type;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< byte >( 0 );
        }
    }
}