using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCoffeeCatBusinessObject.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_CoffeeShop_CoffeeNameCoffeeID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Table_TableID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropIndex(
                name: "IX_Staff_Email",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Email",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "CoffeeShop");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Staff",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customer",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "CoffeeNameCoffeeID",
                table: "Comment",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_CoffeeNameCoffeeID",
                table: "Comment",
                newName: "IX_Comment_CustomerID");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Table",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Table",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "Drink",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "CoffeeShopCoffeeID",
                table: "Comment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Comment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CustomerPackage",
                columns: table => new
                {
                    CPID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPackage", x => x.CPID);
                    table.ForeignKey(
                        name: "FK_CustomerPackage_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_CustomerPackage_Subscription_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionID");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Account_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_Account_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CoffeeShopCoffeeID",
                table: "Comment",
                column: "CoffeeShopCoffeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CustomerID",
                table: "Account",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_RoleID",
                table: "Account",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_StaffID",
                table: "Account",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPackage_CustomerID",
                table: "CustomerPackage",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPackage_SubscriptionID",
                table: "CustomerPackage",
                column: "SubscriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_CoffeeShop_CoffeeShopCoffeeID",
                table: "Comment",
                column: "CoffeeShopCoffeeID",
                principalTable: "CoffeeShop",
                principalColumn: "CoffeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Customer_CustomerID",
                table: "Comment",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Table_TableID",
                table: "Order",
                column: "TableID",
                principalTable: "Table",
                principalColumn: "TableID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_CoffeeShop_CoffeeShopCoffeeID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Customer_CustomerID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Table_TableID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "CustomerPackage");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Comment_CoffeeShopCoffeeID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "CoffeeShopCoffeeID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Staff",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customer",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Comment",
                newName: "CoffeeNameCoffeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_CustomerID",
                table: "Comment",
                newName: "IX_Comment_CoffeeNameCoffeeID");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Table",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staff",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "UnitPrice",
                table: "Drink",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Branch",
                table: "CoffeeShop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeShopCoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoffeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Email",
                table: "Staff",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Email",
                table: "Customer",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manager_CoffeeShopCoffeeID",
                table: "Manager",
                column: "CoffeeShopCoffeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_Email",
                table: "Manager",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_CoffeeShop_CoffeeNameCoffeeID",
                table: "Comment",
                column: "CoffeeNameCoffeeID",
                principalTable: "CoffeeShop",
                principalColumn: "CoffeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Table_TableID",
                table: "Order",
                column: "TableID",
                principalTable: "Table",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
