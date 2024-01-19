using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCoffeeCatBusinessObject.Migrations
{
    public partial class Initialize_v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatProduct",
                columns: table => new
                {
                    CatProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CatProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatProduct", x => x.CatProductID);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeShop",
                columns: table => new
                {
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Branch = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeShop", x => x.CoffeeID);
                });

            migrationBuilder.CreateTable(
                name: "Drink",
                columns: table => new
                {
                    DrinkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrinkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.DrinkID);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    SubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPercent = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.SubscriptionID);
                });

            migrationBuilder.CreateTable(
                name: "Cat",
                columns: table => new
                {
                    CatID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CofffeeShopCoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat", x => x.CatID);
                    table.ForeignKey(
                        name: "FK_Cat_CoffeeShop_CofffeeShopCoffeeID",
                        column: x => x.CofffeeShopCoffeeID,
                        principalTable: "CoffeeShop",
                        principalColumn: "CoffeeID");
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeShopCoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ManagerID);
                    table.ForeignKey(
                        name: "FK_Manager_CoffeeShop_CoffeeShopCoffeeID",
                        column: x => x.CoffeeShopCoffeeID,
                        principalTable: "CoffeeShop",
                        principalColumn: "CoffeeID");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CoffeeShopCoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_CoffeeShop_CoffeeShopCoffeeID",
                        column: x => x.CoffeeShopCoffeeID,
                        principalTable: "CoffeeShop",
                        principalColumn: "CoffeeID");
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    TableID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CoffeeShopCoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.TableID);
                    table.ForeignKey(
                        name: "FK_Table_CoffeeShop_CoffeeShopCoffeeID",
                        column: x => x.CoffeeShopCoffeeID,
                        principalTable: "CoffeeShop",
                        principalColumn: "CoffeeID");
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CofffeeShopCoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrinkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CatProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menu_CatProduct_CatProductID",
                        column: x => x.CatProductID,
                        principalTable: "CatProduct",
                        principalColumn: "CatProductID");
                    table.ForeignKey(
                        name: "FK_Menu_CoffeeShop_CofffeeShopCoffeeID",
                        column: x => x.CofffeeShopCoffeeID,
                        principalTable: "CoffeeShop",
                        principalColumn: "CoffeeID");
                    table.ForeignKey(
                        name: "FK_Menu_Drink_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drink",
                        principalColumn: "DrinkID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Subscription_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    TotalItem = table.Column<int>(type: "int", nullable: false),
                    TotalDiscount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TableID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Order_Table_TableID",
                        column: x => x.TableID,
                        principalTable: "Table",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDeatailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDeatailID);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cat_CofffeeShopCoffeeID",
                table: "Cat",
                column: "CofffeeShopCoffeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Email",
                table: "Customer",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SubscriptionID",
                table: "Customer",
                column: "SubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_CoffeeShopCoffeeID",
                table: "Manager",
                column: "CoffeeShopCoffeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_Email",
                table: "Manager",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CatProductID",
                table: "Menu",
                column: "CatProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CofffeeShopCoffeeID",
                table: "Menu",
                column: "CofffeeShopCoffeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_DrinkID",
                table: "Menu",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TableID",
                table: "Order",
                column: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_MenuID",
                table: "OrderDetail",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CoffeeShopCoffeeID",
                table: "Staff",
                column: "CoffeeShopCoffeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Email",
                table: "Staff",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Table_CoffeeShopCoffeeID",
                table: "Table",
                column: "CoffeeShopCoffeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "CatProduct");

            migrationBuilder.DropTable(
                name: "Drink");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "CoffeeShop");
        }
    }
}
