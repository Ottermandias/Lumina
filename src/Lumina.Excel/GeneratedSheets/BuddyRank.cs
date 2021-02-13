// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyRank", columnHash: 0xdbf43666 )]
    public class BuddyRank : ExcelRow
    {
        
        public uint ExpRequired;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ExpRequired = parser.ReadColumn< uint >( 0 );
        }
    }
}