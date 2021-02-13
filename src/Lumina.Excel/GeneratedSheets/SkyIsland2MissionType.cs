// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionType", columnHash: 0xcd4cb81c )]
    public class SkyIsland2MissionType : ExcelRow
    {
        
        public bool Type;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< bool >( 0 );
        }
    }
}