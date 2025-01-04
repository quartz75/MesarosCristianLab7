using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;
using MesarosCristianLab7.Models;

namespace MesarosCristianLab7;

public class ListProduct
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    [SQLiteNetExtensions.Attributes.ForeignKey(typeof(ShopList))]
    public int ShopListID { get; set; }
    public int ProductID { get; set; }
}