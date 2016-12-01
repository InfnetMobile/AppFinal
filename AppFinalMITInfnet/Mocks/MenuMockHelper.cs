using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Commands;

namespace AppFinalMITInfnet
{
    public static class MenuMockHelper
    {
        static Menu menu => new Menu
        {
            Items = new List<MenuItem>
                        {
                            new MenuItem
                            {
                                MenuId = 0,
                                MenuItemBackgroundImage = "customer.png",
                                MenuItemIco = "\uf0b1",
                                MenuItemName = "Clientes"
                            },
                            new MenuItem
                            {
                                MenuId = 1,
                                MenuItemBackgroundImage = "product.png",
                                MenuItemIco = "\uf187",
                                MenuItemName = "Produtos"
                            },
                            new MenuItem
                            {
                                MenuId = 2,
                                MenuItemBackgroundImage = "order.jpg",
                                MenuItemIco = "\uf0ce",
                                MenuItemName = "Pedidos"
                            },
                            new MenuItem
                            {
                                MenuId = 3,
                                MenuItemBackgroundImage = "company.jpg",
                                MenuItemIco = "\uf1ad",
                                MenuItemName = "Empresas"
                            },
                            new MenuItem
                            {
                                MenuId = 4,
                                MenuItemBackgroundImage = "setup.jpg",
                                MenuItemIco = "\uf013",
                                MenuItemName = "Configurações"
                            },
                            new MenuItem
                            {
                                MenuId = 5,
                                MenuItemBackgroundImage = "roadexit.jpg",
                                MenuItemIco = "\uf08b",
                                MenuItemName = "Sair"
                            }
                        }
        };

        public static ObservableCollection<MenuItem> Menus => new ObservableCollection<MenuItem>(menu.Items);
    }
}