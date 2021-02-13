// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonLayer", columnHash: 0x832a5a83 )]
    public class DeepDungeonLayer : ExcelRow
    {
        
        public LazyRow< DeepDungeon > DeepDungeon;
        public byte FloorSet;
        public LazyRow< DeepDungeonMap5X > RoomA;
        public LazyRow< DeepDungeonMap5X > RoomB;
        public LazyRow< DeepDungeonMap5X > RoomC;
        public byte WepMinLv;
        public byte ArmourMinLv;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            DeepDungeon = new LazyRow< DeepDungeon >( lumina, parser.ReadColumn< byte >( 0 ), language );
            FloorSet = parser.ReadColumn< byte >( 1 );
            RoomA = new LazyRow< DeepDungeonMap5X >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            RoomB = new LazyRow< DeepDungeonMap5X >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            RoomC = new LazyRow< DeepDungeonMap5X >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            WepMinLv = parser.ReadColumn< byte >( 5 );
            ArmourMinLv = parser.ReadColumn< byte >( 6 );
        }
    }
}