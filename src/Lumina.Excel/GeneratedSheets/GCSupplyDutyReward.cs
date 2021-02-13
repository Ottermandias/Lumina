// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCSupplyDutyReward", columnHash: 0x6be0e840 )]
    public class GCSupplyDutyReward : ExcelRow
    {
        
        public uint ExperienceSupply;
        public uint ExperienceProvisioning;
        public uint SealsExpertDelivery;
        public uint SealsSupply;
        public uint SealsProvisioning;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ExperienceSupply = parser.ReadColumn< uint >( 0 );
            ExperienceProvisioning = parser.ReadColumn< uint >( 1 );
            SealsExpertDelivery = parser.ReadColumn< uint >( 2 );
            SealsSupply = parser.ReadColumn< uint >( 3 );
            SealsProvisioning = parser.ReadColumn< uint >( 4 );
        }
    }
}