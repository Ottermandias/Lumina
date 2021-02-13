// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSystemDefine", columnHash: 0xd16a1b6c )]
    public class BGMSystemDefine : ExcelRow
    {
        
        public float Define;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Define = parser.ReadColumn< float >( 0 );
        }
    }
}