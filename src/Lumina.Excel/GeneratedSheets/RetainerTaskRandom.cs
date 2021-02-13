// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskRandom", columnHash: 0x9ab94c53 )]
    public class RetainerTaskRandom : ExcelRow
    {
        
        public SeString Name;
        public short Requirement;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Requirement = parser.ReadColumn< short >( 1 );
        }
    }
}