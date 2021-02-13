// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUp", columnHash: 0xde74b4c4 )]
    public class ENpcDressUp : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< ENpcDressUpDress > ENpcDressUpDress;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            ENpcDressUpDress = new LazyRow< ENpcDressUpDress >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}