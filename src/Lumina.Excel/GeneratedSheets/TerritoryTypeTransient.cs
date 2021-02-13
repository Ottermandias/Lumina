// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryTypeTransient", columnHash: 0xd9b2883f )]
    public class TerritoryTypeTransient : ExcelRow
    {
        
        public short OffsetZ;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            OffsetZ = parser.ReadColumn< short >( 0 );
        }
    }
}