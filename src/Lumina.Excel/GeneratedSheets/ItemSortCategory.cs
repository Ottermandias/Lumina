// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSortCategory", columnHash: 0xdcfd9eba )]
    public class ItemSortCategory : ExcelRow
    {
        
        public byte Param;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Param = parser.ReadColumn< byte >( 0 );
        }
    }
}