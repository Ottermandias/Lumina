// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionProcStatus", columnHash: 0xd870e208 )]
    public class ActionProcStatus : ExcelRow
    {
        
        public LazyRow< Status > Status;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Status = new LazyRow< Status >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}