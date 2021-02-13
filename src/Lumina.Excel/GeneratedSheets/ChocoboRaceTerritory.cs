// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTerritory", columnHash: 0x39e8d543 )]
    public class ChocoboRaceTerritory : ExcelRow
    {
        
        public LazyRow< GoldSaucerTextData > Name;
        public int Icon;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = new LazyRow< GoldSaucerTextData >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Icon = parser.ReadColumn< int >( 1 );
        }
    }
}