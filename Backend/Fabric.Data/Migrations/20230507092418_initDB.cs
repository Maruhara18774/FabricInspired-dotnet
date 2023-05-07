using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fabric.Data.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SettingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Stretch = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    WovedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatternID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Products_Patterns_PatternID",
                        column: x => x.PatternID,
                        principalTable: "Patterns",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Moonboards",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moonboards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Moonboards_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Moonboards_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Metre = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "CreatedBy", "Description", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { "CTGR000000", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6302), new Guid("00000000-0000-0000-0000-000000000000"), "Browse all our silk fabrics here, and use the filter to refine your options! Our evolving array of designer & Liberty deadstock silk fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls one-of-a-kind and never to be seen again!  Whether you're looking for silk prints, georgettes, crepes, challis, twills, satins, suitings or jacquards you'll be sure to find something suitable online! Shop silk fabrics online today!", "Silk Fabrics", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6309), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "CTGR000001", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6347), new Guid("00000000-0000-0000-0000-000000000000"), "Browse all of our range of rayon, viscose & other cellulose fabrics here and use the filter to refine your options. Our evolving array of designer & Liberty deadstock cellulose fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls of of a kind and never to be seen again! Whether you're looking for vintage-inspired prints, georgettes, crepes, challis, twills, satins, suitings or knitted fabrics you'll be sure to find something suitable online! Shop rayon, viscose fabrics online today!", "Rayon, Viscose & More", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6347), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "CTGR000002", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6365), new Guid("00000000-0000-0000-0000-000000000000"), "Browse all our merino fabrics here and use the filter to refine your options! Merino is one of the world’s oldest breeds of sheep, originating in Spain as far back as the 12th century. Merino sheep produce extremely fine and soft wool, making fabric that is breathable, moisture-wicking and suitable for all seasons as well as a huge variety of uses. Browse our huge range of merino fabrics online here, including our exclusive, ethically-made ZQ Premium Merino range in over 35 shades, along with our ever-evolving range of deadstock merino fabrics in heavyweight, activewear, textured and striped styles! Shop merino fabrics online today!", "Merino Fabrics", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6366), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "CTGR000003", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6374), new Guid("00000000-0000-0000-0000-000000000000"), "Browse all our linen fabrics here, and use the filter to refine your options! Here at The Fabric Store, linen is one of our favourite fibres. As well as being super easy to sew, linen fabric has a lovely earthy feel, starting off crisp but softening beautifully in time with wash and wear. The flax plant, from which linen fibres are harvested, consumes far less water than cotton and requires fewer chemicals and pesticides making it a great eco fabric choice for the environmentally conscious. Browse our huge range of linen fabrics online here, including our exclusive ranges and our ever-evolving collection of deadstock linens as well! Our exclusive ranges include certified Organic Linen, Gingham Linen, Vintage Finish Linen and Heavyweight Linen. Find an array of patterns, textures and colours in our deadstock linens too! Shop linen fabrics online today!", "Linen Fabrics", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6375), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "CTGR000004", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6380), new Guid("00000000-0000-0000-0000-000000000000"), "Browse our huge range of cotton fabrics here and use the filter to refine your options. This collection includes our exclusive certified Organic Cotton Sweatshirting + Rib and Upcycled Cotton ranges. Our evolving array of designer & Liberty deadstock cotton fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls one-of-a-kind and never to be seen again! Whether you're looking for cotton prints, stripes, checks, shirtings, sateens, denims, chambrays, twills, corduroys, sateens or knitted fabrics, you'll be sure to find something suitable online! Shop cotton fabrics online today!", "Cotton Fabrics", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6380), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "CTGR000005", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6386), new Guid("00000000-0000-0000-0000-000000000000"), "Browse all our cotton, viscose & synthetic blend knitted fabrics here and use the filter to refine your options. This collection includes our exclusive certified Organic Cotton Sweatshirting + Rib too. Our evolving array of designer & Liberty deadstock knitted fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls of-of-a-kind and never to be seen again! Whether you're looking for relaxed linens, super soft cottons, fluid viscose and stretchy activewear jerseys. For a casual project with flair choose our printed Liberty cotton knits, and for the cooler days, our range of sweatshirtings are ideal! Shop knitted & jersey fabric online today!", "Jersey & Knitted Fabrics", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6387), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "ID", "Active", "Created", "CreatedBy", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { "PTRN000000", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6399), new Guid("00000000-0000-0000-0000-000000000000"), "Abstract", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6399), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000001", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6412), new Guid("00000000-0000-0000-0000-000000000000"), "Animal", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6412), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000002", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6418), new Guid("00000000-0000-0000-0000-000000000000"), "Check", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6418), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000003", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6422), new Guid("00000000-0000-0000-0000-000000000000"), "Conversational", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6423), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000004", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6475), new Guid("00000000-0000-0000-0000-000000000000"), "Floral", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6475), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000005", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6481), new Guid("00000000-0000-0000-0000-000000000000"), "Geometric", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6481), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000006", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6487), new Guid("00000000-0000-0000-0000-000000000000"), "Large Scale", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6487), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000007", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6494), new Guid("00000000-0000-0000-0000-000000000000"), "Motif", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6495), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000008", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6500), new Guid("00000000-0000-0000-0000-000000000000"), "No Pattern", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6500), new Guid("00000000-0000-0000-0000-000000000000") },
                    { "PTRN000009", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6505), new Guid("00000000-0000-0000-0000-000000000000"), "Paisley", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6505), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "ID", "Active", "Created", "CreatedBy", "SettingType", "Updated", "UpdatedBy", "Value1", "Value2" },
                values: new object[,]
                {
                    { "STTG000000", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6519), new Guid("00000000-0000-0000-0000-000000000000"), "Width", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6520), new Guid("00000000-0000-0000-0000-000000000000"), "0", "49" },
                    { "STTG000001", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6533), new Guid("00000000-0000-0000-0000-000000000000"), "Width", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6533), new Guid("00000000-0000-0000-0000-000000000000"), "50", "60" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "CreatedBy", "Description", "Name", "PatternID", "Price", "Quantity", "Updated", "UpdatedBy", "Weight", "Width", "WovedIn" },
                values: new object[] { "PRDT000000", true, "CTGR000002", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6540), new Guid("00000000-0000-0000-0000-000000000000"), "// Our single jersey ZQ Premium Merino in our seasonal colour, Turmeric. This fabric is knitted from ZQ certified merino and produced just for us in our range of exclusive colours. The superfine merino fibre is spun into a single twist yarn, creating a slightly textural fabric with naturally occurring slubs throughout. The single jersey knit structure gives this fabric mechanical stretch and great drape. Beautifully soft, merino jersey is ideal for all seasons and perfect for next-to-skin basics and layering.", "ZQ Premium Merino - Turmeric", "PTRN000008", 36.0, 99.0, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6541), new Guid("00000000-0000-0000-0000-000000000000"), 1, 59.0, "Dalat City and Nam Dinh City, Vietnam" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "CreatedBy", "Description", "Name", "PatternID", "Price", "Quantity", "Stretch", "Updated", "UpdatedBy", "Weight", "Width", "WovedIn" },
                values: new object[,]
                {
                    { "PRDT000001", true, "CTGR000002", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6588), new Guid("00000000-0000-0000-0000-000000000000"), "// This lightweight army green merino blend jersey has subtle pointelle holes, backed with a very fine plated stripe. Perfect for street and activewear for those chillier days.", "Pindot Merino Blend Jersey - Army", "PTRN000006", 18.0, 99.0, 1, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6588), new Guid("00000000-0000-0000-0000-000000000000"), 2, 47.0, "Vietnam" },
                    { "PRDT000002", true, "CTGR000000", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6600), new Guid("00000000-0000-0000-0000-000000000000"), "// A deadstock silk/ cotton in teal and black. This lightweight fabric has been cleverly woven with sheer black warp striped with a  deep teal stripe, then a sheer black and teal striped weft creating a dimensional check fabric. A sheer fabric with a dry hand feel and no stretch. Ideal for shirts like the Bloom, dresses like the Paint or Ivy.", "Sheer Check Silk / Cotton - Teal / Black", "PTRN000002", 24.0, 99.0, 2, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6600), new Guid("00000000-0000-0000-0000-000000000000"), 1, 57.0, "China" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Active", "Created", "CreatedBy", "ProductID", "Updated", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { "IMGE000000", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6657), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000000", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6659), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395842/Fabric/ZQ_Merino_Tumeric_Swatch_1000x1000_sixf1d.webp" },
                    { "IMGE000001", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6670), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000000", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6670), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395881/Fabric/ZQ_Merino_Tumeric_Hang_36b686ea-16c4-447b-9426-d9ea304bf617_1000x1000_ij2rgq.webp" },
                    { "IMGE000002", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6675), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000000", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6675), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395881/Fabric/ZQ_Merino_Tumeric_Roll_1000x1000_a9dzr7.webp" },
                    { "IMGE000003", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6680), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000000", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6680), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395883/Fabric/ZQ_Merino_Tumeric_Ruler_2864b442-a822-45b5-a5ac-90877b38be7f_1000x1000_fvgqio.webp" },
                    { "IMGE000004", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6685), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000001", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6685), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396716/Fabric/Pindot_Merino_Blend_Jersey_Army_Swatch_1000x1000_pn9pxf.webp" },
                    { "IMGE000005", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6691), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000001", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6691), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396715/Fabric/Pindot_Merino_Blend_Jersey_Army_Hang_1000x1000_vyvzd0.webp" },
                    { "IMGE000006", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6695), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000001", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6696), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396716/Fabric/Pindot_Merino_Blend_Jersey_Army_Roll_1000x1000_tqamxz.webp" },
                    { "IMGE000007", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6700), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000001", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6700), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396716/Fabric/Pindot_Merino_Blend_Jersey_Army_Ruler_1000x1000_ai1wi2.jpg" },
                    { "IMGE000008", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6705), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000002", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6705), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Swatch_OO_1000x1000_yedrcg.webp" },
                    { "IMGE000009", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6710), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000002", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6710), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Hang_1000x1000_qjtbii.webp" },
                    { "IMGE000010", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6715), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000002", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6715), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Roll_1000x1000_gxqmax.webp" },
                    { "IMGE000011", true, new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6720), new Guid("00000000-0000-0000-0000-000000000000"), "PRDT000002", new DateTime(2023, 5, 7, 16, 24, 18, 725, DateTimeKind.Local).AddTicks(6721), new Guid("00000000-0000-0000-0000-000000000000"), "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Ruler_1000x1000_jpi3h1.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductID",
                table: "Images",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Moonboards_ProductID",
                table: "Moonboards",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Moonboards_UserID",
                table: "Moonboards",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PatternID",
                table: "Products",
                column: "PatternID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductID",
                table: "Sales",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Moonboards");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Patterns");
        }
    }
}
