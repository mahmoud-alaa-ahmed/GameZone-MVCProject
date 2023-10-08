using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameZone.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "018f722a-8678-48e6-ae14-b93807080bc3", null, "Admin", "ADMIN" },
                    { "1eba95a2-9c87-476b-83f1-131d51d41bd8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bea19558-d13a-487a-bb7c-aa53106e120c", 0, "30d2900e-4343-4a6b-8723-86d6583a052a", "ahmedalaa@gmail.com", false, "Ahmed Alaa", false, null, "AHMEDALAA@GMAIL.COM", "AHMED_ALAA", "AQAAAAIAAYagAAAAEKgst/1nhShuZ7Bl3Lr04fOz8u4o4Z1Rt3WGLubIYCp5wLC9aH3uerZMEhcn1VForA==", null, false, "f3ac88ba-b821-49de-8a20-99639d0bff7b", false, "ahmed_alaa" },
                    { "ff715a05-8098-4bc1-9e29-aed8d229e1ac", 0, "3e10a8d4-1d89-474b-b441-f6ba75557f22", "mahmoudalaa72@gmail.com", false, "Mahmoud Alaa", false, null, "MAHMOUDALAA72@GMAIL.COM", "MAHMOUD_ALAA", "AQAAAAIAAYagAAAAEBEAluQkNnwdh3Ovc0QKX9Vt6uUOfEPIh2ziJtNRR16wrHXCfahUO1JebS7jb9Z66A==", null, false, "302dcdf9-badd-400f-b13b-558546a70faa", false, "mahmoud_alaa" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sports" },
                    { 2, "Action" },
                    { 3, "Adventure" },
                    { 4, "Racing" },
                    { 5, "Fighting" },
                    { 6, "Film" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "bi bi-playstation", "PlayStation" },
                    { 2, "bi bi-xbox", "XBox" },
                    { 3, "bi bi-nintendo-switch", "Nintendo Switch" },
                    { 4, "bi bi-pc-display", "PC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1eba95a2-9c87-476b-83f1-131d51d41bd8", "bea19558-d13a-487a-bb7c-aa53106e120c" },
                    { "018f722a-8678-48e6-ae14-b93807080bc3", "ff715a05-8098-4bc1-9e29-aed8d229e1ac" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "Cover", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 2, "b7743952-5bc5-48ed-b0fc-f7c643ef09ea.png", "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal and published by Ubisoft. It is the twelfth major installment in the Assassin's Creed series.", "Assassin's Creed Valhalla" },
                    { 2, 3, "5f2a1cff-7e87-424d-8198-9d2626e2b4de.png", "Among Us is a multiplayer party game developed and published by InnerSloth.", "Among Us" },
                    { 3, 1, "61084baa-edf7-4b53-ab57-ab804f6fca23.png", "FIFA 23 is a football simulation video game published by Electronic Arts.", "FIFA 23" },
                    { 4, 2, "6146b83a-514f-4b68-8355-c2cfab7c5656.png", "The Witcher 3: Wild Hunt is an action role-playing game developed and published by CD Projekt.", "The Witcher 3" },
                    { 5, 5, "915e6c02-cec0-4692-aaca-13fedcb0247b.jpg", "Red Dead Redemption 2 is an action-adventure game developed and published by Rockstar Games.", "Red Dead Redemption 2" },
                    { 6, 5, "814959b7-41d0-4412-ad0a-fe52f0fd3a91.jpg", "The Legend of Zelda: Breath of the Wild is an action-adventure video game developed and published by Nintendo.", "The Legend of Zelda" },
                    { 7, 3, "597d0d8c-9ba6-441d-991a-c68b9df45023.jpg", "Overwatch is a team-based multiplayer first-person shooter game developed and published by Blizzard Entertainment.", "Overwatch" },
                    { 8, 4, "ae63a01a-564c-42f1-b0f0-8493171e4d6f.jpg", "Pokémon GO is an augmented reality mobile game developed and published by Niantic in collaboration with Nintendo and The Pokémon Company.", "Pokemon Go" }
                });

            migrationBuilder.InsertData(
                table: "GameDevices",
                columns: new[] { "DeviceId", "GameId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 1 },
                    { 2, 3 },
                    { 2, 8 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1eba95a2-9c87-476b-83f1-131d51d41bd8", "bea19558-d13a-487a-bb7c-aa53106e120c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "018f722a-8678-48e6-ae14-b93807080bc3", "ff715a05-8098-4bc1-9e29-aed8d229e1ac" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "GameDevices",
                keyColumns: new[] { "DeviceId", "GameId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "018f722a-8678-48e6-ae14-b93807080bc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eba95a2-9c87-476b-83f1-131d51d41bd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bea19558-d13a-487a-bb7c-aa53106e120c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff715a05-8098-4bc1-9e29-aed8d229e1ac");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
