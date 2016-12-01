using System;
using Prism.Commands;
using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class MenuItem
    {
        public string MenuItemName { get; set; }

        public string MenuItemIco { get; set; }

        public string MenuItemBackgroundImage { get; set; }

        public string MenuItemNameFor => MenuItemName[0].ToString();

        [ForeignKey(typeof(Menu))]
        public int MenuId { get; set; }
    }
}