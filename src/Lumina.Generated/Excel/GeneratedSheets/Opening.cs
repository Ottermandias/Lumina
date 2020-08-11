// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Opening", columnHash: 0xdd0fcc95 )]
    public class Opening : IExcelRow
    {
        
        public string Name;
        public LazyRow< Quest > Quest;
        public string Unknown2;
        public string Unknown3;
        public string Unknown4;
        public string Unknown5;
        public string Unknown6;
        public string Unknown7;
        public string Unknown8;
        public string Unknown9;
        public string Unknown10;
        public string Unknown11;
        public string Unknown12;
        public string Unknown13;
        public string Unknown14;
        public string Unknown15;
        public string Unknown16;
        public string Unknown17;
        public string Unknown18;
        public string Unknown19;
        public string Unknown20;
        public string Unknown21;
        public string Unknown22;
        public string Unknown23;
        public string Unknown24;
        public string Unknown25;
        public string Unknown26;
        public string Unknown27;
        public string Unknown28;
        public string Unknown29;
        public string Unknown30;
        public string Unknown31;
        public string Unknown32;
        public string Unknown33;
        public string Unknown34;
        public string Unknown35;
        public string Unknown36;
        public string Unknown37;
        public string Unknown38;
        public string Unknown39;
        public string Unknown40;
        public string Unknown41;
        public uint Unknown42;
        public uint Unknown43;
        public uint Unknown44;
        public uint Unknown45;
        public uint Unknown46;
        public uint Unknown47;
        public uint Unknown48;
        public uint Unknown49;
        public uint Unknown50;
        public uint Unknown51;
        public uint Unknown52;
        public uint Unknown53;
        public uint Unknown54;
        public uint Unknown55;
        public uint Unknown56;
        public uint Unknown57;
        public uint Unknown58;
        public uint Unknown59;
        public uint Unknown60;
        public uint Unknown61;
        public uint Unknown62;
        public uint Unknown63;
        public uint Unknown64;
        public uint Unknown65;
        public uint Unknown66;
        public uint Unknown67;
        public uint Unknown68;
        public uint Unknown69;
        public uint Unknown70;
        public uint Unknown71;
        public uint Unknown72;
        public uint Unknown73;
        public uint Unknown74;
        public uint Unknown75;
        public uint Unknown76;
        public uint Unknown77;
        public uint Unknown78;
        public uint Unknown79;
        public uint Unknown80;
        public uint Unknown81;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< string >( 2 );
            Unknown3 = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< string >( 4 );
            Unknown5 = parser.ReadColumn< string >( 5 );
            Unknown6 = parser.ReadColumn< string >( 6 );
            Unknown7 = parser.ReadColumn< string >( 7 );
            Unknown8 = parser.ReadColumn< string >( 8 );
            Unknown9 = parser.ReadColumn< string >( 9 );
            Unknown10 = parser.ReadColumn< string >( 10 );
            Unknown11 = parser.ReadColumn< string >( 11 );
            Unknown12 = parser.ReadColumn< string >( 12 );
            Unknown13 = parser.ReadColumn< string >( 13 );
            Unknown14 = parser.ReadColumn< string >( 14 );
            Unknown15 = parser.ReadColumn< string >( 15 );
            Unknown16 = parser.ReadColumn< string >( 16 );
            Unknown17 = parser.ReadColumn< string >( 17 );
            Unknown18 = parser.ReadColumn< string >( 18 );
            Unknown19 = parser.ReadColumn< string >( 19 );
            Unknown20 = parser.ReadColumn< string >( 20 );
            Unknown21 = parser.ReadColumn< string >( 21 );
            Unknown22 = parser.ReadColumn< string >( 22 );
            Unknown23 = parser.ReadColumn< string >( 23 );
            Unknown24 = parser.ReadColumn< string >( 24 );
            Unknown25 = parser.ReadColumn< string >( 25 );
            Unknown26 = parser.ReadColumn< string >( 26 );
            Unknown27 = parser.ReadColumn< string >( 27 );
            Unknown28 = parser.ReadColumn< string >( 28 );
            Unknown29 = parser.ReadColumn< string >( 29 );
            Unknown30 = parser.ReadColumn< string >( 30 );
            Unknown31 = parser.ReadColumn< string >( 31 );
            Unknown32 = parser.ReadColumn< string >( 32 );
            Unknown33 = parser.ReadColumn< string >( 33 );
            Unknown34 = parser.ReadColumn< string >( 34 );
            Unknown35 = parser.ReadColumn< string >( 35 );
            Unknown36 = parser.ReadColumn< string >( 36 );
            Unknown37 = parser.ReadColumn< string >( 37 );
            Unknown38 = parser.ReadColumn< string >( 38 );
            Unknown39 = parser.ReadColumn< string >( 39 );
            Unknown40 = parser.ReadColumn< string >( 40 );
            Unknown41 = parser.ReadColumn< string >( 41 );
            Unknown42 = parser.ReadColumn< uint >( 42 );
            Unknown43 = parser.ReadColumn< uint >( 43 );
            Unknown44 = parser.ReadColumn< uint >( 44 );
            Unknown45 = parser.ReadColumn< uint >( 45 );
            Unknown46 = parser.ReadColumn< uint >( 46 );
            Unknown47 = parser.ReadColumn< uint >( 47 );
            Unknown48 = parser.ReadColumn< uint >( 48 );
            Unknown49 = parser.ReadColumn< uint >( 49 );
            Unknown50 = parser.ReadColumn< uint >( 50 );
            Unknown51 = parser.ReadColumn< uint >( 51 );
            Unknown52 = parser.ReadColumn< uint >( 52 );
            Unknown53 = parser.ReadColumn< uint >( 53 );
            Unknown54 = parser.ReadColumn< uint >( 54 );
            Unknown55 = parser.ReadColumn< uint >( 55 );
            Unknown56 = parser.ReadColumn< uint >( 56 );
            Unknown57 = parser.ReadColumn< uint >( 57 );
            Unknown58 = parser.ReadColumn< uint >( 58 );
            Unknown59 = parser.ReadColumn< uint >( 59 );
            Unknown60 = parser.ReadColumn< uint >( 60 );
            Unknown61 = parser.ReadColumn< uint >( 61 );
            Unknown62 = parser.ReadColumn< uint >( 62 );
            Unknown63 = parser.ReadColumn< uint >( 63 );
            Unknown64 = parser.ReadColumn< uint >( 64 );
            Unknown65 = parser.ReadColumn< uint >( 65 );
            Unknown66 = parser.ReadColumn< uint >( 66 );
            Unknown67 = parser.ReadColumn< uint >( 67 );
            Unknown68 = parser.ReadColumn< uint >( 68 );
            Unknown69 = parser.ReadColumn< uint >( 69 );
            Unknown70 = parser.ReadColumn< uint >( 70 );
            Unknown71 = parser.ReadColumn< uint >( 71 );
            Unknown72 = parser.ReadColumn< uint >( 72 );
            Unknown73 = parser.ReadColumn< uint >( 73 );
            Unknown74 = parser.ReadColumn< uint >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< uint >( 76 );
            Unknown77 = parser.ReadColumn< uint >( 77 );
            Unknown78 = parser.ReadColumn< uint >( 78 );
            Unknown79 = parser.ReadColumn< uint >( 79 );
            Unknown80 = parser.ReadColumn< uint >( 80 );
            Unknown81 = parser.ReadColumn< uint >( 81 );
        }
    }
}