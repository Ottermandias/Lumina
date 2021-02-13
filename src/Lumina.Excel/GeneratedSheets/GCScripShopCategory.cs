// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCScripShopCategory", columnHash: 0x9b330d8a )]
    public class GCScripShopCategory : ExcelRow
    {
        
        public LazyRow< GrandCompany > GrandCompany;
        public sbyte Tier;
        public sbyte SubCategory;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            GrandCompany = new LazyRow< GrandCompany >( lumina, parser.ReadColumn< sbyte >( 0 ), language );
            Tier = parser.ReadColumn< sbyte >( 1 );
            SubCategory = parser.ReadColumn< sbyte >( 2 );
        }
    }
}