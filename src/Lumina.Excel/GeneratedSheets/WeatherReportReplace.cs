// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherReportReplace", columnHash: 0x2020acf6 )]
    public class WeatherReportReplace : ExcelRow
    {
        
        public LazyRow< PlaceName > PlaceNameSub;
        public LazyRow< PlaceName > PlaceNameParent;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            PlaceNameSub = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            PlaceNameParent = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}