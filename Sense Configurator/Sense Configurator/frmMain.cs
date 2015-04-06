using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace Sense_Configurator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             GV.ConfigurationCreationDate = DateTime.Now;
            GV.ConfigurationLastEditDate = DateTime.Now;
            GV.ConfigurationLastEditUsername = "Ricky Vaughn";

            using (SqlConnection connection = new SqlConnection(GV.connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Configurator " + 
                                                                                    "(BoxID, Brand, StoreID, SenseIP, SenseSubnet, " +
                                                                                    "SenseGateway, SenseDNS1, SenseDNS2, APIID, APIKey, "+
                                                                                    "RadioMode, LampMode, BlinkMode, iPadMode, OldestCallMode, "+
                                                                                    "AutoUploadMode, SenseSerialCommPort, CurrentMaxAddress, OccupancyFilter, SystemMaxAddress, "+
                                                                                    "ConfigurationCreationDate, ConfigurationLastEditDate, ConfigurationLastEditUsername,"+
                                                                                    "ADR1GRP, ADR1ID,ADR2GRP, ADR2ID,ADR3GRP, ADR3ID,ADR4GRP, ADR4ID,ADR5GRP, ADR5ID,"+
                                                                                    "ADR6GRP, ADR6ID,ADR7GRP, ADR7ID,ADR8GRP, ADR8ID,ADR9GRP, ADR9ID,ADR10GRP, ADR10ID,"+
                                                                                    "ADR11GRP, ADR11ID,ADR12GRP, ADR12ID,ADR13GRP, ADR13ID,ADR14GRP, ADR14ID,ADR15GRP, "+
                                                                                    "ADR15ID,ADR16GRP, ADR16ID,ADR17GRP, ADR17ID,ADR18GRP, ADR18ID,ADR19GRP, ADR19ID,"+
                                                                                    "ADR20GRP, ADR20ID,ADR21GRP, ADR21ID,ADR22GRP, ADR22ID,ADR23GRP, ADR23ID,ADR24GRP, "+
                                                                                    "ADR24ID,ADR25GRP, ADR25ID,ADR26GRP, ADR26ID,ADR27GRP, ADR27ID,ADR28GRP, ADR28ID,"+
                                                                                    "ADR29GRP, ADR29ID,ADR30GRP, ADR30ID,ADR31GRP, ADR31ID,ADR32GRP, ADR32ID,ADR33GRP, "+
                                                                                    "ADR33ID,ADR34GRP, ADR34ID,ADR35GRP, ADR35ID,ADR36GRP, ADR36ID,ADR37GRP, ADR37ID,"+
                                                                                    "ADR38GRP, ADR38ID,ADR39GRP, ADR39ID,ADR40GRP, ADR40ID,ADR41GRP, ADR41ID,ADR42GRP, "+
                                                                                    "ADR42ID,ADR43GRP, ADR43ID,ADR44GRP, ADR44ID,ADR45GRP, ADR45ID,ADR46GRP, ADR46ID,"+
                                                                                    "ADR47GRP, ADR47ID,ADR48GRP, ADR48ID,ADR49GRP, ADR49ID,ADR50GRP, ADR50ID) " +
                                                                                    "VALUES "+
                                                                                    "(@BoxID, @Brand, @StoreID, @SenseIP, @SenseSubnet, "+
                                                                                    "@SenseGateway, @SenseDNS1, @SenseDNS2, @APIID, @APIKey, "+
                                                                                    "@RadioMode, @LampMode, @BlinkMode, @iPadMode, @OldestCallMode, "+
                                                                                    "@AutoUploadMode, @SenseSerialCommPort, @CurrentMaxAddress, @OccupancyFilter, @SystemMaxAddress, "+
                                                                                    "@ConfigurationCreationDate, @ConfigurationLastEditDate, @ConfigurationLastEditUsername,"+
                                                                                    "@ADR1GRP, @ADR1ID,@ADR2GRP, @ADR2ID,@ADR3GRP, @ADR3ID,@ADR4GRP, @ADR4ID,@ADR5GRP, @ADR5ID,"+
                                                                                    "@ADR6GRP, @ADR6ID,@ADR7GRP, @ADR7ID,@ADR8GRP, @ADR8ID,@ADR9GRP, @ADR9ID,@ADR10GRP, @ADR10ID,"+
                                                                                    "@ADR11GRP, @ADR11ID,@ADR12GRP, @ADR12ID,@ADR13GRP, @ADR13ID,@ADR14GRP,@ADR14ID,@ADR15GRP, "+
                                                                                    "@ADR15ID,@ADR16GRP, @ADR16ID,@ADR17GRP, @ADR17ID,@ADR18GRP, @ADR18ID,@ADR19GRP, @ADR19ID,"+
                                                                                    "@ADR20GRP, @ADR20ID,@ADR21GRP, @ADR21ID,@ADR22GRP, @ADR22ID,@ADR23GRP, @ADR23ID,@ADR24GRP, "+
                                                                                    "@ADR24ID,@ADR25GRP, @ADR25ID,@ADR26GRP, @ADR26ID,@ADR27GRP, @ADR27ID,@ADR28GRP, @ADR28ID,"+
                                                                                    "@ADR29GRP, @ADR29ID,@ADR30GRP, @ADR30ID,@ADR31GRP, @ADR31ID,@ADR32GRP, @ADR32ID,@ADR33GRP, "+
                                                                                    "@ADR33ID,@ADR34GRP, @ADR34ID,@ADR35GRP, @ADR35ID,@ADR36GRP, @ADR36ID,@ADR37GRP, @ADR37ID,"+
                                                                                    "@ADR38GRP, @ADR38ID,@ADR39GRP, @ADR39ID,@ADR40GRP, @ADR40ID,@ADR41GRP, @ADR41ID,@ADR42GRP, "+
                                                                                    "@ADR42ID,@ADR43GRP, @ADR43ID,@ADR44GRP, @ADR44ID,@ADR45GRP, @ADR45ID,@ADR46GRP, @ADR46ID,"+
                                                                                    "@ADR47GRP, @ADR47ID,@ADR48GRP, @ADR48ID,@ADR49GRP, @ADR49ID,@ADR50GRP, @ADR50ID)");
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@BoxID", GV.BoxID);
                cmd.Parameters.AddWithValue("@Brand", GV.Brand);
                cmd.Parameters.AddWithValue("@StoreID", GV.StoreID);
                cmd.Parameters.AddWithValue("@SenseIP", GV.SenseIP);
                cmd.Parameters.AddWithValue("@SenseSubnet", GV.SenseSubnet);
                cmd.Parameters.AddWithValue("@SenseGateway", GV.SenseGateway);
                cmd.Parameters.AddWithValue("@SenseDNS1", GV.SenseDNS1);
                cmd.Parameters.AddWithValue("@SenseDNS2", GV.SenseDNS2);
                cmd.Parameters.AddWithValue("@APIID", GV.APIID);
                cmd.Parameters.AddWithValue("@APIKey", GV.APIKey);
                cmd.Parameters.AddWithValue("@RadioMode", GV.RadioMode);
                cmd.Parameters.AddWithValue("@LampMode", GV.LampMode);
                cmd.Parameters.AddWithValue("@BlinkMode", GV.BlinkMode);
                cmd.Parameters.AddWithValue("@iPadMode", GV.iPadMode);
                cmd.Parameters.AddWithValue("@OldestCallMode", GV.OldestCallMode);
                cmd.Parameters.AddWithValue("@AutoUploadMode", GV.AutoUploadMode);
                cmd.Parameters.AddWithValue("@SenseSerialCommPort", GV.SenseSerialCommPort);
                cmd.Parameters.AddWithValue("@CurrentMaxAddress", GV.CurrentMaxAddress);
                cmd.Parameters.AddWithValue("@OccupancyFilter", GV.OccupancyFilter);
                cmd.Parameters.AddWithValue("@SystemMaxAddress", GV.SystemMaxAddress);
                cmd.Parameters.AddWithValue("@ConfigurationCreationDate", GV.ConfigurationCreationDate);
                cmd.Parameters.AddWithValue("@ConfigurationLastEditDate", GV.ConfigurationLastEditDate);
                cmd.Parameters.AddWithValue("@ConfigurationLastEditUsername", GV.ConfigurationLastEditUsername);

                cmd.Parameters.AddWithValue("@ADR1GRP", GV.ADR1GRP);
                cmd.Parameters.AddWithValue("@ADR1ID", GV.ADR1ID);
                cmd.Parameters.AddWithValue("@ADR2GRP", GV.ADR2GRP);
                cmd.Parameters.AddWithValue("@ADR2ID", GV.ADR2ID);
                cmd.Parameters.AddWithValue("@ADR3GRP", GV.ADR3GRP);
                cmd.Parameters.AddWithValue("@ADR3ID", GV.ADR3ID);
                cmd.Parameters.AddWithValue("@ADR4GRP", GV.ADR4GRP);
                cmd.Parameters.AddWithValue("@ADR4ID", GV.ADR4ID);
                cmd.Parameters.AddWithValue("@ADR5GRP", GV.ADR5GRP);
                cmd.Parameters.AddWithValue("@ADR5ID", GV.ADR5ID);
                cmd.Parameters.AddWithValue("@ADR6GRP", GV.ADR6GRP);
                cmd.Parameters.AddWithValue("@ADR6ID", GV.ADR6ID);
                cmd.Parameters.AddWithValue("@ADR7GRP", GV.ADR7GRP);
                cmd.Parameters.AddWithValue("@ADR7ID", GV.ADR7ID);
                cmd.Parameters.AddWithValue("@ADR8GRP", GV.ADR8GRP);
                cmd.Parameters.AddWithValue("@ADR8ID", GV.ADR8ID);
                cmd.Parameters.AddWithValue("@ADR9GRP", GV.ADR9GRP);
                cmd.Parameters.AddWithValue("@ADR9ID", GV.ADR9ID);
                cmd.Parameters.AddWithValue("@ADR10GRP", GV.ADR10GRP);
                cmd.Parameters.AddWithValue("@ADR10ID", GV.ADR10ID);
                cmd.Parameters.AddWithValue("@ADR11GRP", GV.ADR11GRP);
                cmd.Parameters.AddWithValue("@ADR11ID", GV.ADR11ID);
                cmd.Parameters.AddWithValue("@ADR12GRP", GV.ADR12GRP);
                cmd.Parameters.AddWithValue("@ADR12ID", GV.ADR12ID);
                cmd.Parameters.AddWithValue("@ADR13GRP", GV.ADR13GRP);
                cmd.Parameters.AddWithValue("@ADR13ID", GV.ADR13ID);
                cmd.Parameters.AddWithValue("@ADR14GRP", GV.ADR14GRP);
                cmd.Parameters.AddWithValue("@ADR14ID", GV.ADR14ID);
                cmd.Parameters.AddWithValue("@ADR15GRP", GV.ADR15GRP);
                cmd.Parameters.AddWithValue("@ADR15ID", GV.ADR15ID);
                cmd.Parameters.AddWithValue("@ADR16GRP", GV.ADR16GRP);
                cmd.Parameters.AddWithValue("@ADR16ID", GV.ADR16ID);
                cmd.Parameters.AddWithValue("@ADR17GRP", GV.ADR17GRP);
                cmd.Parameters.AddWithValue("@ADR17ID", GV.ADR17ID);
                cmd.Parameters.AddWithValue("@ADR18GRP", GV.ADR18GRP);
                cmd.Parameters.AddWithValue("@ADR18ID", GV.ADR18ID);
                cmd.Parameters.AddWithValue("@ADR19GRP", GV.ADR19GRP);
                cmd.Parameters.AddWithValue("@ADR19ID", GV.ADR19ID);
                cmd.Parameters.AddWithValue("@ADR20GRP", GV.ADR20GRP);
                cmd.Parameters.AddWithValue("@ADR20ID", GV.ADR20ID);
                cmd.Parameters.AddWithValue("@ADR21GRP", GV.ADR21GRP);
                cmd.Parameters.AddWithValue("@ADR21ID", GV.ADR21ID);
                cmd.Parameters.AddWithValue("@ADR22GRP", GV.ADR22GRP);
                cmd.Parameters.AddWithValue("@ADR22ID", GV.ADR22ID);
                cmd.Parameters.AddWithValue("@ADR23GRP", GV.ADR23GRP);
                cmd.Parameters.AddWithValue("@ADR23ID", GV.ADR23ID);
                cmd.Parameters.AddWithValue("@ADR24GRP", GV.ADR24GRP);
                cmd.Parameters.AddWithValue("@ADR24ID", GV.ADR24ID);
                cmd.Parameters.AddWithValue("@ADR25GRP", GV.ADR25GRP);
                cmd.Parameters.AddWithValue("@ADR25ID", GV.ADR25ID);
                cmd.Parameters.AddWithValue("@ADR26GRP", GV.ADR26GRP);
                cmd.Parameters.AddWithValue("@ADR26ID", GV.ADR26ID);
                cmd.Parameters.AddWithValue("@ADR27GRP", GV.ADR27GRP);
                cmd.Parameters.AddWithValue("@ADR27ID", GV.ADR27ID);
                cmd.Parameters.AddWithValue("@ADR28GRP", GV.ADR28GRP);
                cmd.Parameters.AddWithValue("@ADR28ID", GV.ADR28ID);
                cmd.Parameters.AddWithValue("@ADR29GRP", GV.ADR29GRP);
                cmd.Parameters.AddWithValue("@ADR29ID", GV.ADR29ID);
                cmd.Parameters.AddWithValue("@ADR30GRP", GV.ADR30GRP);
                cmd.Parameters.AddWithValue("@ADR30ID", GV.ADR30ID);
                cmd.Parameters.AddWithValue("@ADR31GRP", GV.ADR31GRP);
                cmd.Parameters.AddWithValue("@ADR31ID", GV.ADR31ID);
                cmd.Parameters.AddWithValue("@ADR32GRP", GV.ADR32GRP);
                cmd.Parameters.AddWithValue("@ADR32ID", GV.ADR32ID);
                cmd.Parameters.AddWithValue("@ADR33GRP", GV.ADR33GRP);
                cmd.Parameters.AddWithValue("@ADR33ID", GV.ADR33ID);
                cmd.Parameters.AddWithValue("@ADR34GRP", GV.ADR34GRP);
                cmd.Parameters.AddWithValue("@ADR34ID", GV.ADR34ID);
                cmd.Parameters.AddWithValue("@ADR35GRP", GV.ADR35GRP);
                cmd.Parameters.AddWithValue("@ADR35ID", GV.ADR35ID);
                cmd.Parameters.AddWithValue("@ADR36GRP", GV.ADR36GRP);
                cmd.Parameters.AddWithValue("@ADR36ID", GV.ADR36ID);
                cmd.Parameters.AddWithValue("@ADR37GRP", GV.ADR37GRP);
                cmd.Parameters.AddWithValue("@ADR37ID", GV.ADR37ID);
                cmd.Parameters.AddWithValue("@ADR38GRP", GV.ADR38GRP);
                cmd.Parameters.AddWithValue("@ADR38ID", GV.ADR38ID);
                cmd.Parameters.AddWithValue("@ADR39GRP", GV.ADR39GRP);
                cmd.Parameters.AddWithValue("@ADR39ID", GV.ADR39ID);
                cmd.Parameters.AddWithValue("@ADR40GRP", GV.ADR40GRP);
                cmd.Parameters.AddWithValue("@ADR40ID", GV.ADR40ID);
                cmd.Parameters.AddWithValue("@ADR41GRP", GV.ADR41GRP);
                cmd.Parameters.AddWithValue("@ADR41ID", GV.ADR41ID);
                cmd.Parameters.AddWithValue("@ADR42GRP", GV.ADR42GRP);
                cmd.Parameters.AddWithValue("@ADR42ID", GV.ADR42ID);
                cmd.Parameters.AddWithValue("@ADR43GRP", GV.ADR43GRP);
                cmd.Parameters.AddWithValue("@ADR43ID", GV.ADR43ID);
                cmd.Parameters.AddWithValue("@ADR44GRP", GV.ADR44GRP);
                cmd.Parameters.AddWithValue("@ADR44ID", GV.ADR44ID);
                cmd.Parameters.AddWithValue("@ADR45GRP", GV.ADR45GRP);
                cmd.Parameters.AddWithValue("@ADR45ID", GV.ADR45ID);
                cmd.Parameters.AddWithValue("@ADR46GRP", GV.ADR46GRP);
                cmd.Parameters.AddWithValue("@ADR46ID", GV.ADR46ID);
                cmd.Parameters.AddWithValue("@ADR47GRP", GV.ADR47GRP);
                cmd.Parameters.AddWithValue("@ADR47ID", GV.ADR47ID);
                cmd.Parameters.AddWithValue("@ADR48GRP", GV.ADR48GRP);
                cmd.Parameters.AddWithValue("@ADR48ID", GV.ADR48ID);
                cmd.Parameters.AddWithValue("@ADR49GRP", GV.ADR49GRP);
                cmd.Parameters.AddWithValue("@ADR49ID", GV.ADR49ID);
                cmd.Parameters.AddWithValue("@ADR50GRP", GV.ADR50GRP);
                cmd.Parameters.AddWithValue("@ADR50ID", GV.ADR50ID);
                
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        }
    }
}
