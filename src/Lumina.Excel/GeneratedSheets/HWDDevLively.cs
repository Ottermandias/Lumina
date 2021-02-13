// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDDevLively", columnHash: 0xe18cbe18 )]
    public class HWDDevLively : ExcelRow
    {
        
        public LazyRow< ENpcBase > ENPC;
        public ushort Unknown1;
        public byte Unknown2;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ENPC = new LazyRow< ENpcBase >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}