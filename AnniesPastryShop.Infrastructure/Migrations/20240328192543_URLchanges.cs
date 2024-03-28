using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnniesPastryShop.Infrastructure.Migrations
{
    public partial class URLchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b672cab0-8bea-4cd7-8ecc-5a31e2823af2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc7e63f9-d362-4b01-96d7-254679f27426");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ceabd70-7fa1-4a2e-b7b2-31c91f5b74e4", "f91cf1bb-2747-41c5-b74c-a2940e0dfb67", "Administrator", null },
                    { "6a507206-39aa-41d9-971d-91dc2ebd8fe4", "84905cc4-e2c3-4d62-8801-aab014a175be", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bef7d71c-92a2-4559-89d0-af99780d55ab", "AQAAAAEAACcQAAAAEFelg4MJGOjWF+FVTmh1Cha3UECXt6LXO5uq5EcVbpac0PeYdu5ZnZclhdVnznkDrw==", "40406175-2641-471c-b0d9-fd25ae018a15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e713492-f911-43db-ae8f-8a163e311a1e", "AQAAAAEAACcQAAAAEPbr6Hw+IAoIdRbHkRmZzqslj/osZH5EudztKO9fHvuQnLbWSTvo41mzWIXAFkdbjg==", "56df329c-9438-4738-bf66-ad33ae328e06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9576873-e1e2-43cb-8d23-455bba9ec21f", "AQAAAAEAACcQAAAAELogKJdPtYXEXKiZGsHGnHcb+u2GGc1IpR0nfkkgd2Ocgxenhdn1uyTXJEISXkoQDg==", "265708b9-e2dc-4bbf-b088-ff937af0403c" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dwi4j1ek5sey5sdt2zieu/FOTOBODEN-INDIVIDUELL-BEDRUCKBARER-VINYLBODEN.jpg?rlkey=flbp0ko4cym1v9fhg9sf0x9nc&dl=1");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/lxo1tjn4re7ht3anh58d7/If-you-are-anywhere-in-the-city-center-of-Le-Mans.jpg?rlkey=yp6wjxl8lbb2h3zoolgsrb90h&dl=1");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9b5jca6a1blm0c62k29r4/Blood-Splattered-Cake.jpg?rlkey=k3obmzm1hin7t28775dz5lbgv&dl=1");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/d9g8ibm0235gdf8z2ndw9/Chocolate-Strawberry-Cake.jpg?rlkey=mdx8hl5kt7exhol04bz686kfo&dl=1");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/2ubtzb4vzkyeolsbk55n8/315091820_218444830534539_6229220902423040954_n.jpg?rlkey=vakd1rubnbe5fa13m779jgr29&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/o2etu594dc2474nd5vl0f/Best-Chocolate-Cake-Recipe-My-Baking-Addiction.jpg?rlkey=0agguya24yh32jv5s4fboy8h3&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/gayvfgchf5wxr1bpi9glh/Chocolate-Raspberry-Cheesecake-Baker-by-Nature.jpg?rlkey=1ajrtc4ytgdudc51bz249zlj0&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bcf92t6nldq2sl6h2lcjs/close-up-view-delicious-chocolate-cake-concept.jpg?rlkey=4y7xr1kdmz7ce6wctphr6x1we&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/fxt280sfqfdg5qwaijk35/delicious-chocolate-cake-with-copy-space.jpg?rlkey=s44dk81z5h2i9rfczj8qsyf64&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/qd8s8dmsguyxfnaqkmr7i/Moist-and-Fudgy-Chocolate-Cake-Butternut-Bakery.jpg?rlkey=u72ldtchsp5lj16i2q30oh7pg&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/x7oy572908eldnptwc0z5/Tarta-muerte-por-chocolate.jpg?rlkey=vtlg6qz752ynjq301wo3ji3wr&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/myhrmzpc7lwf2zt61t2pi/umesh-soni-Jl3O1S_Fk4-unsplash.jpg?rlkey=cgtawt4ohhgdjb7l1vkg6znuu&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xsnno4rcn1y0jb8dpycpy/umesh-soni-sSCldtAG7lk-unsplash.jpg?rlkey=74duhygeebl3gfocr0tftfejf&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/1pknj4bibwcsgok3lgpww/ai-generated-8569860_1280.jpg?rlkey=yhwdufs7fjxku6olb003q819j&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/4fxkoygiyrtswn7xyrj21/amirali-mirhashemian-EfkMkUXs0fU-unsplash.jpg?rlkey=uutba03eoeb2l5mwgx9gz5d6o&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/5ddz1v57wwz9sea58zy5q/cake-5377289_1280.jpg?rlkey=9yjbmr3s4vepwuk9q4glbykuw&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/7r7varzvgbbwcnjjzjkow/Oreo-Red-Velvet-Cake-Salt-Baker.jpg?rlkey=lz5owdw9quux6lhivu6n9sb3l&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/45cemyhbok2ndpxblif4a/Red-Velvet-Cake-with-Cream-Cheese-Frosting-Cooking-Classy.jpg?rlkey=rtrrwhno35uuxrttoqj3xoobl&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/4hgnoov97niyx7k23ezyb/Red-Velvet-Cake-Recipe.jpg?rlkey=w3t7pfiy5lbl4uhch6huvymx6&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/rfl598aqnm0iiixeyebyi/Red-velvet-taart-bakken-recept.jpg?rlkey=tal1b51u3afcitj3bhc5yq7o8&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/8p9714npibflovprqf1l6/UVCcOKdg.jpg?rlkey=vl46na7sp5umys2dask4hzpgr&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6qzous7x97fgb2dkp1rvi/front-view-red-cake-slice-fruit-cake-piece-inside-plate-with-fresh-cranberries-strawberries-grey-tea_140725-20808.jpg?rlkey=mqyi0eqa2ll5ratcbywutwp5z&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xpdb0spkxfx1okx6575tw/alex-lvrs-On2VseHUDXw-unsplash.jpg?rlkey=oe34rk54wzqoidnqxs1v12l1l&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6ky3k5l7ser7yxe85fm6p/Basic-Vanilla-Cake.jpg?rlkey=dms3o5ulcoyf3h9mfhamqe7sg&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/mu9o3z3q74qa16mnbzs3t/Best-White-Cake-Recipe-Baker-by-Nature.jpg?rlkey=0lbnbclyezwrhys3pzs7h8ylq&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ffwecsntxoxcycy304q0r/chiasheng-tai-B4QQAYBn8fU-unsplash.jpg?rlkey=rzf5i9oe7odelvdfgv2zbavsq&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xhi1yt8q88xxld4es6ulk/Copycat-Whole-Foods-Berry-Chantilly-Cake.jpg?rlkey=6z1qeif038wynl8e5sg4krzf0&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bxzrawil5mnd2732g6g0s/Strawberry-Shortcake-Cake.jpg?rlkey=z3ywp3uj6lpafn9mcnxicuw2o&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/kfozoc28tjfv2zjms6byv/The-Most-Amazing-Classic-Vanilla-Cake-Lil-Cookie.jpg?rlkey=u09qcejdcy4tkxenmpxj1i8ba&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/rtfduqrng1u9q1to5ziwv/cake-3060458_1280.jpg?rlkey=06lct5t2kg1f3pxuo3pn6cur9&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/335e6zv45z5cyidi9v3f2/Creamsicle-Cake.jpg?rlkey=vlpig4o459e9cwxcs9x1y4oo5&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ka3zibige368w6shvxiy2/Lemon-Layer-Cake-with-The-Most-Lemony-Buttercream.jpg?rlkey=667gsce3yrgnsrszfxz590atc&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dh21m4u2jjiwt4o0dtlmh/Lemon-Sponge-Cake.jpg?rlkey=8rp241t0dz9l9dq5lq7mzvww3&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h2edxdrgb9dg6juz33xi8/Lemonade-Cake-with-Cream-Cheese-Frosting-Zesty-Lemon-Cake-Recipe.jpg?rlkey=jnhy2ohh41ui7w8g31vl3n6pk&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xq9qgn62rinqbnh6j93hv/pexels-pixabay-264939.jpg?rlkey=xzcxsvs1oo5g3znqh7xw5m5wm&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ssbzm1u8kcfc1pgc5hwfk/Thick-Homemade-Lemon-Curd.jpg?rlkey=j3guenwmvrhx811hxill7urtk&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/s42uufah282b6h6zgbb4u/new-york-cheese-cake-7500156_1280.jpg?rlkey=c8ho65gvs22qa56hwt4g2s6p1&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/b1x62yu33lrrv59tcp3hf/Apple-Pie-Recipe-The-BEST-Live-Well-Bake-Often.jpg?rlkey=2bt5ts08n7sms2wothwugnzw3&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/198v4264d3rqqqdpnmrxj/Apple-Pie.jpg?rlkey=kdihdl3rcasom5fbk5da2mc34&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/4or8cx9jcwdfetdntfc3d/Deep-Dish-Apple-Pie-SundaySupper.jpg?rlkey=nx0s073wlmqf29mnacvld8a9g&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/y1zilp730ev7s9yiftfqg/diliara-garifullina-D7X-GMeTV7U-unsplash.jpg?rlkey=cp4mpumb0uxq2orshwws9api0&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xqlw0a5a8iorexv0pzyk3/hugo-aitken-PqYvDBwpXpU-unsplash.jpg?rlkey=0b4gv7bcb8ghazye2s5r7diti&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/m0it2y8xxvi8p3dibkanp/patrick-fore-LDnctIMQGeY-unsplash.jpg?rlkey=odgq0lzxy1tkm34q20rf6x2fc&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ij9a4nfuazqxk1tyvkjw0/Foolproof-Cherry-Pie-The-Best-Cherry-Pie-Recipe-from-Scratch.jpg?rlkey=fsf7j1aqezw7b84fzmdzjuzsm&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/1u7730n7rxust5jehco4m/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats.jpg?rlkey=hvd3ztvgogqrr7hkug1p9m590&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h7tsp3bllbxmed9gfgvau/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats-1.jpg?rlkey=4cwitp3zz8vvvvdiyyko9h400&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/5vqmj53sno2epmy3tndd6/Old-Fashioned-Cherry-Pie.jpg?rlkey=i4027pfxnk25rx72g5f6gmgrz&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/mvuex013vlp0wv20ftbik/Simple-Vegan-Cherry-Pie-My-Vegan-Minimalist.jpg?rlkey=hbjkzkikpd08sszz9fzhqos5l&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/nkdqj9jfos3926ij92rs0/Sour-Cherry-Pie.jpg?rlkey=cjap94gnsv5rrpnijx0vsult8&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9u2264pak6pjyx90uupo9/Simple-Vegan-Cherry-Pie-My-Vegan-Minimalist-1.jpg?rlkey=bv089cngrwm2bxodol8c0w6ya&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6i9hm4z5hs58o4c7dthin/Best-Blueberry-Pie-Recipe-vegan-easy.jpg?rlkey=6g1md46kl4hboldyyaxtpt435&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dcmw398ksz3st4b7gg1f3/Best-Ever-Blueberry-Pie.jpg?rlkey=umhreq1dv3sqsx2j82658zvc4&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/t6mon1g94h5xt1nud7pgi/Blueberry-Cheesecake-Pie.jpg?rlkey=a1lxel1ckqkt2axli3xuqszdj&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/khqktslyxp36pifhhqsw0/Blueberry-Pie-With-Coconut-Oil-Crust-Vegan.jpg?rlkey=aachu0o5nx37xcdb2tx4j81pq&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/62l0fxd9a4m3vla6yli5d/Blueberry-Pie.jpg?rlkey=e7f7nzjxwg9est0rxfmqnqin1&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/aozn1ya6kq238zqa079ft/Blueberry-Pie-1.jpg?rlkey=gvolf7axe2wpf23w3dk7tx402&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/e4zv4py21c08znzige0sp/Classic-Blueberry-Pie-From-Scratch.jpg?rlkey=vqyxvrf0t13w6q3dojlocynth&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/do4vzdr0eqbnpi4fztknm/Simply-the-Best-Blueberry-Pie-Recipe-Sally-s-Baking-Addiction.jpg?rlkey=lz51zzhc0c0dvgepvtbfe4fif&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/89l6xvb147kovcbx8gdv7/Brown-Butter-Bourbon-Pecan-Pie.jpg?rlkey=igmhpie8jvd1oau8zvg35lwsd&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/389notkf50zpviwd309cw/Easy-Thanksgiving-Pumpkin-Pie.jpg?rlkey=dtuvzrgd2n3nu7lwc5q2ikuuj&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/nj7prp3lxzcs33wnrzepy/Gluten-Free-Dairy-Free-Pumpkin-Pie.jpg?rlkey=2ely5y2ebspoie200q3ymkujq&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/j4onkyzzs2h3zkczj3xqy/NameBright-Coming-Soon.jpg?rlkey=jxosgoqgxrv1q63bh1hew2b8l&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/poqazei76a2vcagnv1ejd/Perfect-Pumpkin-Pie-Cooking-Classy.jpg?rlkey=x2473hkwpykqzubxyheyht1fp&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9g5c8o3a1h4o725is7iy9/Pumpkin-Pie-Recipe-VIDEO.jpg?rlkey=nvqxp3pabkms71g0evmcwfxxj&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/unq720ne5hkzjj43or1vy/Pumpkin-Pie-Recipe.jpg?rlkey=l57p8vuk86f88449d0lmxcgrd&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/a2y5dlvgygvlvysl1binn/The-Best-Pumpkin-Pie-Recipe-STACIE-FLINNER.jpg?rlkey=8oh1b8savk8qhtrnixifdpob7&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/jejaub0d6l4rasqxpzhz2/Caf-Mocha-Cupcakes.jpg?rlkey=inbu6swikodonp9fawuyjqbua&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6dxgfsj7890tp52rsjsne/Chocolate-Mocha-Cupcake.jpg?rlkey=hlbxsdfvea5ua44r7bjuabfgy&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/v51328mpw3e490mf593dy/Mocha-Cupcakes-Plus-Coffee-Bark-Recipe.jpg?rlkey=y1el9g2bs6a85uasefykihewe&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/chfqjvzkwfw988ouckzsl/Mocha-Cupcakes-with-Espresso-Buttercream-Recipe-by-Alpine-Ella.jpg?rlkey=2z5raaokb7so0114y40xk5cep&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 66,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/flsja5cbnhrxccrlpzyj9/Mocha-Cupcakes-1.jpg?rlkey=9vdcywr46s6pksxevmxndqelx&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 67,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/0cnyn6o4ulj5y6mr2toia/Mocha-Cupcakes-2.jpg?rlkey=qcu4hw039p7g2g8nrjg5cyqlq&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 68,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bogvoufvdvmjvjqa3dedi/Die-Vanille-Cupcakes-Ihr-bester-Party-Freund.jpg?rlkey=t8s80zh9jdvsf2bpqr900yaw7&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/gl3se9u7vn9wtrl4efnpy/Fresh-Strawberry-Cupcakes-Cupcake-Recipe-Loaded-With-Strawberries.jpg?rlkey=zywlvvv6sz6ivexkdob8s5kt4&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 70,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/hagwv1zx1wpzs2jj6s612/Strawberry-Cupcakes-In-Bloom-Bakery.jpg?rlkey=74iyv19rphfmz72qemcnubcws&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 71,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/yefkc8iym37v1ulj6iv0c/Strawberry-Cupcakes-Strawberry-Frosting-Live-Well-Bake-Often.jpg?rlkey=6hmavgwy4ztdag5vxmrv5jdvl&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 72,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/hcegkksrkkwqdioer0dvu/Strawberry-Shortcake-Cupcakes.jpg?rlkey=5b9cpfxmgoopq3uu93i33tsod&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 73,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9fr4vfibkjfg3kd7xeiab/The-BEST-Homemade-Strawberry-Frosting-How-to-Make-Frosting.jpg?rlkey=bf76sh659ztvd9k0ja9e3skgi&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 74,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/f6u1lgfg24lkpnrxbvx5o/Banana-Caramel-Cupcakes-with-Caramel-Cream-Cheese-Frosting-Recipe.jpg?rlkey=rpxy5aotrpcgomkk3ysgjlgsi&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 75,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/053x0ximzu2wasdehukwj/Banana-Chocolate-Chip-Cupcakes-with-Cream-Cheese-Frosting-Cooking-Classy.jpg?rlkey=6i8d1ie5day2j5jo06m8ecfl4&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 76,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/8cw9phg2slso2c7ftbo3e/Banana-Cupcakes-Recipe-Sally-s-Baking-Addiction.jpg?rlkey=1dz9e1668tlf74pg74fnvzexl&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 77,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9mysqrd34tyj67ito28bf/Banana-Cupcakes-with-Cream-Cheese-Frosting.jpg?rlkey=wghu1ojk398veztcb1u71xots&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 78,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/b4w74ejtsu4uorgukbcaz/Peanut-Butter-Banana-Cupcakes-The-Best-Cupcake-Recipe.jpg?rlkey=j3gjapl4dryk52da27stwcf75&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 79,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/v8f1b1dhgzcyafz992wxi/Banana-Cupcakes-with-Cream-Cheese-Frosting-1.jpg?rlkey=hn7vci8yio9zcoqdr2rjrjha1&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 80,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/c0id55usyvdtpvlm63zcu/Cannoli-Cupcakes.jpg?rlkey=w2ygc4vbl2mw83hdh198bhsw4&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 81,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/p27ytufvbm9kug9qajsmf/Chocolate-Cupcakes-with-Pistachios-and-Cognac-Buttercream-Frosting.jpg?rlkey=trwjtuu1ceapsexycd2x42kgf&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 82,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/mamd7esz4lxuy9b0jakef/Chocolate-Pistachio-Cupcakes.jpg?rlkey=q61pcchjfrcgv4fezbnvb04xg&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 83,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/jx92qgiganev8uyntueh8/Matcha-Green-Tea-Cupcakes.jpg?rlkey=8d4wwzk0dkpz0dsdoepnzahh8&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 84,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/n1ffp5xztnmggofptrd1k/Pistachio-Cupcakes-Recipe.jpg?rlkey=8xdf9rb9quxepq6sd7jb2w32x&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 85,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/3nlucly1o1epiequ8kw3q/Pistachio-Cupcakes-with-Orange-Mascarpone-Frosting.jpg?rlkey=3ph9ht9woaohnkzbrqkos8igv&dl=1");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 86,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/z3mhkmgqvsc291wzy6pgv/Pistachio-Rosewater-Cupcakes-with-Saffron-Frosting.jpg?rlkey=dpeglysqx3dnqck5p6d5mpofn&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/jfl56ni9f5de2s3sqmhw0/umesh-soni-LDnmyOaA-ew-unsplash.jpg?rlkey=pr92cxu0uh1y7z7ex7ioxwjzu&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/rfl598aqnm0iiixeyebyi/Red-velvet-taart-bakken-recept.jpg?rlkey=tal1b51u3afcitj3bhc5yq7o8&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xhi1yt8q88xxld4es6ulk/Copycat-Whole-Foods-Berry-Chantilly-Cake.jpg?rlkey=6z1qeif038wynl8e5sg4krzf0&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/q21mza82deuh2ilvgy99n/Dairy-Free-Lemon-Cake-Caked-by-Katie.jpg?rlkey=p6w64sedulhmhqpnehdh1wt0q&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h1wughcwngoiu4j2pwfpv/Tourte-aux-pommes-Apple-Pie-Dessert-classique-Am-ricain.jpg?rlkey=107amabi0pirjykgmn668cul6&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h7tsp3bllbxmed9gfgvau/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats-1.jpg?rlkey=4cwitp3zz8vvvvdiyyko9h400&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/m8zwvnvpyt7o3y4qx22ye/Simply-the-Best-Blueberry-Pie-Recipe-Sally-s-Baking-Addiction-1.jpg?rlkey=lmu3n9nsxtj66y82lba9qpoeo&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bza3ossr8ha2h223h566s/Sustainable-Eating.jpg?rlkey=8fgdqgaji17otjqvg53sqgdn6&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6eqh8vkdin3x17hzh67vx/Caf-Mocha-Cupcakes-My-Baking-Addiction.jpg?rlkey=a7nym5zdy9koj6uyd6cbwqxw8&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dpjrnn75f8nb99gy40f3m/Homemade-Strawberry-Cupcakes.jpg?rlkey=bwph5bf0rxzsxc9dn5s16rgq0&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/v8f1b1dhgzcyafz992wxi/Banana-Cupcakes-with-Cream-Cheese-Frosting-1.jpg?rlkey=hn7vci8yio9zcoqdr2rjrjha1&dl=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/zop3gaf6hz6pwwp3mgho3/Pistachio-Green-Tea-Cupcakes-with-Matcha-Cream-Cheese-Frosting.jpg?rlkey=gs8rakwj4r28uu723tc9ny0kx&dl=1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ceabd70-7fa1-4a2e-b7b2-31c91f5b74e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a507206-39aa-41d9-971d-91dc2ebd8fe4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b672cab0-8bea-4cd7-8ecc-5a31e2823af2", "15d7baba-a3bc-40ea-988d-c98ab6525f94", "Administrator", null },
                    { "fc7e63f9-d362-4b01-96d7-254679f27426", "caa91073-9976-4719-b6e0-50d664338c79", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5904ab69-908b-437d-8aff-4d0f8c74fe21", "AQAAAAEAACcQAAAAENFKgwyS73j1HHFXVmIatkBgqOgYt29PzgL89EON530wv3YV9sfpKyvDCkg1f6YBOw==", "bec806d2-f999-4dc7-bc2e-e262771d3002" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed0813a-6ee3-42fd-a59f-d20392676c4a", "AQAAAAEAACcQAAAAEEk+UeNjpm74dyoaXtnLmbvw4SNhQrKFh9cMYoyy7n+t3EaiqqiRNbgiKhkpdJItbA==", "8e5e41e9-3208-47d6-9023-7a8bf06edf41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e68bd809-a2da-4fe0-b3a9-b68dbe6ff9e5", "AQAAAAEAACcQAAAAEKBm6jNOULvZHlEtloc9ANzzm75q7ysknGgP21hycY4qGY+4Wi1oF045rnFoNr0w8A==", "c6e705c2-d69c-475b-b71f-20511c13bff0" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dwi4j1ek5sey5sdt2zieu/FOTOBODEN-INDIVIDUELL-BEDRUCKBARER-VINYLBODEN.jpg?rlkey=flbp0ko4cym1v9fhg9sf0x9nc&dl=0");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/lxo1tjn4re7ht3anh58d7/If-you-are-anywhere-in-the-city-center-of-Le-Mans.jpg?rlkey=yp6wjxl8lbb2h3zoolgsrb90h&dl=0");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9b5jca6a1blm0c62k29r4/Blood-Splattered-Cake.jpg?rlkey=k3obmzm1hin7t28775dz5lbgv&dl=0");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/d9g8ibm0235gdf8z2ndw9/Chocolate-Strawberry-Cake.jpg?rlkey=mdx8hl5kt7exhol04bz686kfo&dl=0");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/2ubtzb4vzkyeolsbk55n8/315091820_218444830534539_6229220902423040954_n.jpg?rlkey=vakd1rubnbe5fa13m779jgr29&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/o2etu594dc2474nd5vl0f/Best-Chocolate-Cake-Recipe-My-Baking-Addiction.jpg?rlkey=0agguya24yh32jv5s4fboy8h3&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/gayvfgchf5wxr1bpi9glh/Chocolate-Raspberry-Cheesecake-Baker-by-Nature.jpg?rlkey=1ajrtc4ytgdudc51bz249zlj0&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bcf92t6nldq2sl6h2lcjs/close-up-view-delicious-chocolate-cake-concept.jpg?rlkey=4y7xr1kdmz7ce6wctphr6x1we&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/fxt280sfqfdg5qwaijk35/delicious-chocolate-cake-with-copy-space.jpg?rlkey=s44dk81z5h2i9rfczj8qsyf64&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/qd8s8dmsguyxfnaqkmr7i/Moist-and-Fudgy-Chocolate-Cake-Butternut-Bakery.jpg?rlkey=u72ldtchsp5lj16i2q30oh7pg&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/x7oy572908eldnptwc0z5/Tarta-muerte-por-chocolate.jpg?rlkey=vtlg6qz752ynjq301wo3ji3wr&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/myhrmzpc7lwf2zt61t2pi/umesh-soni-Jl3O1S_Fk4-unsplash.jpg?rlkey=cgtawt4ohhgdjb7l1vkg6znuu&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xsnno4rcn1y0jb8dpycpy/umesh-soni-sSCldtAG7lk-unsplash.jpg?rlkey=74duhygeebl3gfocr0tftfejf&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/1pknj4bibwcsgok3lgpww/ai-generated-8569860_1280.jpg?rlkey=yhwdufs7fjxku6olb003q819j&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/4fxkoygiyrtswn7xyrj21/amirali-mirhashemian-EfkMkUXs0fU-unsplash.jpg?rlkey=uutba03eoeb2l5mwgx9gz5d6o&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/5ddz1v57wwz9sea58zy5q/cake-5377289_1280.jpg?rlkey=9yjbmr3s4vepwuk9q4glbykuw&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/7r7varzvgbbwcnjjzjkow/Oreo-Red-Velvet-Cake-Salt-Baker.jpg?rlkey=lz5owdw9quux6lhivu6n9sb3l&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/45cemyhbok2ndpxblif4a/Red-Velvet-Cake-with-Cream-Cheese-Frosting-Cooking-Classy.jpg?rlkey=rtrrwhno35uuxrttoqj3xoobl&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/4hgnoov97niyx7k23ezyb/Red-Velvet-Cake-Recipe.jpg?rlkey=w3t7pfiy5lbl4uhch6huvymx6&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/rfl598aqnm0iiixeyebyi/Red-velvet-taart-bakken-recept.jpg?rlkey=tal1b51u3afcitj3bhc5yq7o8&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/8p9714npibflovprqf1l6/UVCcOKdg.jpg?rlkey=vl46na7sp5umys2dask4hzpgr&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6qzous7x97fgb2dkp1rvi/front-view-red-cake-slice-fruit-cake-piece-inside-plate-with-fresh-cranberries-strawberries-grey-tea_140725-20808.jpg?rlkey=mqyi0eqa2ll5ratcbywutwp5z&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xpdb0spkxfx1okx6575tw/alex-lvrs-On2VseHUDXw-unsplash.jpg?rlkey=oe34rk54wzqoidnqxs1v12l1l&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6ky3k5l7ser7yxe85fm6p/Basic-Vanilla-Cake.jpg?rlkey=dms3o5ulcoyf3h9mfhamqe7sg&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/mu9o3z3q74qa16mnbzs3t/Best-White-Cake-Recipe-Baker-by-Nature.jpg?rlkey=0lbnbclyezwrhys3pzs7h8ylq&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ffwecsntxoxcycy304q0r/chiasheng-tai-B4QQAYBn8fU-unsplash.jpg?rlkey=rzf5i9oe7odelvdfgv2zbavsq&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xhi1yt8q88xxld4es6ulk/Copycat-Whole-Foods-Berry-Chantilly-Cake.jpg?rlkey=6z1qeif038wynl8e5sg4krzf0&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bxzrawil5mnd2732g6g0s/Strawberry-Shortcake-Cake.jpg?rlkey=z3ywp3uj6lpafn9mcnxicuw2o&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/kfozoc28tjfv2zjms6byv/The-Most-Amazing-Classic-Vanilla-Cake-Lil-Cookie.jpg?rlkey=u09qcejdcy4tkxenmpxj1i8ba&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/rtfduqrng1u9q1to5ziwv/cake-3060458_1280.jpg?rlkey=06lct5t2kg1f3pxuo3pn6cur9&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/335e6zv45z5cyidi9v3f2/Creamsicle-Cake.jpg?rlkey=vlpig4o459e9cwxcs9x1y4oo5&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ka3zibige368w6shvxiy2/Lemon-Layer-Cake-with-The-Most-Lemony-Buttercream.jpg?rlkey=667gsce3yrgnsrszfxz590atc&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dh21m4u2jjiwt4o0dtlmh/Lemon-Sponge-Cake.jpg?rlkey=8rp241t0dz9l9dq5lq7mzvww3&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h2edxdrgb9dg6juz33xi8/Lemonade-Cake-with-Cream-Cheese-Frosting-Zesty-Lemon-Cake-Recipe.jpg?rlkey=jnhy2ohh41ui7w8g31vl3n6pk&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xq9qgn62rinqbnh6j93hv/pexels-pixabay-264939.jpg?rlkey=xzcxsvs1oo5g3znqh7xw5m5wm&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ssbzm1u8kcfc1pgc5hwfk/Thick-Homemade-Lemon-Curd.jpg?rlkey=j3guenwmvrhx811hxill7urtk&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/s42uufah282b6h6zgbb4u/new-york-cheese-cake-7500156_1280.jpg?rlkey=c8ho65gvs22qa56hwt4g2s6p1&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/b1x62yu33lrrv59tcp3hf/Apple-Pie-Recipe-The-BEST-Live-Well-Bake-Often.jpg?rlkey=2bt5ts08n7sms2wothwugnzw3&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/198v4264d3rqqqdpnmrxj/Apple-Pie.jpg?rlkey=kdihdl3rcasom5fbk5da2mc34&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/4or8cx9jcwdfetdntfc3d/Deep-Dish-Apple-Pie-SundaySupper.jpg?rlkey=nx0s073wlmqf29mnacvld8a9g&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/y1zilp730ev7s9yiftfqg/diliara-garifullina-D7X-GMeTV7U-unsplash.jpg?rlkey=cp4mpumb0uxq2orshwws9api0&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xqlw0a5a8iorexv0pzyk3/hugo-aitken-PqYvDBwpXpU-unsplash.jpg?rlkey=0b4gv7bcb8ghazye2s5r7diti&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/m0it2y8xxvi8p3dibkanp/patrick-fore-LDnctIMQGeY-unsplash.jpg?rlkey=odgq0lzxy1tkm34q20rf6x2fc&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/ij9a4nfuazqxk1tyvkjw0/Foolproof-Cherry-Pie-The-Best-Cherry-Pie-Recipe-from-Scratch.jpg?rlkey=fsf7j1aqezw7b84fzmdzjuzsm&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/1u7730n7rxust5jehco4m/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats.jpg?rlkey=hvd3ztvgogqrr7hkug1p9m590&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h7tsp3bllbxmed9gfgvau/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats-1.jpg?rlkey=4cwitp3zz8vvvvdiyyko9h400&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/5vqmj53sno2epmy3tndd6/Old-Fashioned-Cherry-Pie.jpg?rlkey=i4027pfxnk25rx72g5f6gmgrz&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/mvuex013vlp0wv20ftbik/Simple-Vegan-Cherry-Pie-My-Vegan-Minimalist.jpg?rlkey=hbjkzkikpd08sszz9fzhqos5l&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/nkdqj9jfos3926ij92rs0/Sour-Cherry-Pie.jpg?rlkey=cjap94gnsv5rrpnijx0vsult8&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9u2264pak6pjyx90uupo9/Simple-Vegan-Cherry-Pie-My-Vegan-Minimalist-1.jpg?rlkey=bv089cngrwm2bxodol8c0w6ya&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6i9hm4z5hs58o4c7dthin/Best-Blueberry-Pie-Recipe-vegan-easy.jpg?rlkey=6g1md46kl4hboldyyaxtpt435&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dcmw398ksz3st4b7gg1f3/Best-Ever-Blueberry-Pie.jpg?rlkey=umhreq1dv3sqsx2j82658zvc4&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/t6mon1g94h5xt1nud7pgi/Blueberry-Cheesecake-Pie.jpg?rlkey=a1lxel1ckqkt2axli3xuqszdj&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/khqktslyxp36pifhhqsw0/Blueberry-Pie-With-Coconut-Oil-Crust-Vegan.jpg?rlkey=aachu0o5nx37xcdb2tx4j81pq&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/62l0fxd9a4m3vla6yli5d/Blueberry-Pie.jpg?rlkey=e7f7nzjxwg9est0rxfmqnqin1&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/aozn1ya6kq238zqa079ft/Blueberry-Pie-1.jpg?rlkey=gvolf7axe2wpf23w3dk7tx402&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/e4zv4py21c08znzige0sp/Classic-Blueberry-Pie-From-Scratch.jpg?rlkey=vqyxvrf0t13w6q3dojlocynth&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/do4vzdr0eqbnpi4fztknm/Simply-the-Best-Blueberry-Pie-Recipe-Sally-s-Baking-Addiction.jpg?rlkey=lz51zzhc0c0dvgepvtbfe4fif&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/89l6xvb147kovcbx8gdv7/Brown-Butter-Bourbon-Pecan-Pie.jpg?rlkey=igmhpie8jvd1oau8zvg35lwsd&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/389notkf50zpviwd309cw/Easy-Thanksgiving-Pumpkin-Pie.jpg?rlkey=dtuvzrgd2n3nu7lwc5q2ikuuj&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/nj7prp3lxzcs33wnrzepy/Gluten-Free-Dairy-Free-Pumpkin-Pie.jpg?rlkey=2ely5y2ebspoie200q3ymkujq&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/j4onkyzzs2h3zkczj3xqy/NameBright-Coming-Soon.jpg?rlkey=jxosgoqgxrv1q63bh1hew2b8l&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/poqazei76a2vcagnv1ejd/Perfect-Pumpkin-Pie-Cooking-Classy.jpg?rlkey=x2473hkwpykqzubxyheyht1fp&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9g5c8o3a1h4o725is7iy9/Pumpkin-Pie-Recipe-VIDEO.jpg?rlkey=nvqxp3pabkms71g0evmcwfxxj&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/unq720ne5hkzjj43or1vy/Pumpkin-Pie-Recipe.jpg?rlkey=l57p8vuk86f88449d0lmxcgrd&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/a2y5dlvgygvlvysl1binn/The-Best-Pumpkin-Pie-Recipe-STACIE-FLINNER.jpg?rlkey=8oh1b8savk8qhtrnixifdpob7&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/jejaub0d6l4rasqxpzhz2/Caf-Mocha-Cupcakes.jpg?rlkey=inbu6swikodonp9fawuyjqbua&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6dxgfsj7890tp52rsjsne/Chocolate-Mocha-Cupcake.jpg?rlkey=hlbxsdfvea5ua44r7bjuabfgy&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/v51328mpw3e490mf593dy/Mocha-Cupcakes-Plus-Coffee-Bark-Recipe.jpg?rlkey=y1el9g2bs6a85uasefykihewe&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/chfqjvzkwfw988ouckzsl/Mocha-Cupcakes-with-Espresso-Buttercream-Recipe-by-Alpine-Ella.jpg?rlkey=2z5raaokb7so0114y40xk5cep&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 66,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/flsja5cbnhrxccrlpzyj9/Mocha-Cupcakes-1.jpg?rlkey=9vdcywr46s6pksxevmxndqelx&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 67,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/0cnyn6o4ulj5y6mr2toia/Mocha-Cupcakes-2.jpg?rlkey=qcu4hw039p7g2g8nrjg5cyqlq&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 68,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bogvoufvdvmjvjqa3dedi/Die-Vanille-Cupcakes-Ihr-bester-Party-Freund.jpg?rlkey=t8s80zh9jdvsf2bpqr900yaw7&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/gl3se9u7vn9wtrl4efnpy/Fresh-Strawberry-Cupcakes-Cupcake-Recipe-Loaded-With-Strawberries.jpg?rlkey=zywlvvv6sz6ivexkdob8s5kt4&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 70,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/hagwv1zx1wpzs2jj6s612/Strawberry-Cupcakes-In-Bloom-Bakery.jpg?rlkey=74iyv19rphfmz72qemcnubcws&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 71,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/yefkc8iym37v1ulj6iv0c/Strawberry-Cupcakes-Strawberry-Frosting-Live-Well-Bake-Often.jpg?rlkey=6hmavgwy4ztdag5vxmrv5jdvl&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 72,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/hcegkksrkkwqdioer0dvu/Strawberry-Shortcake-Cupcakes.jpg?rlkey=5b9cpfxmgoopq3uu93i33tsod&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 73,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9fr4vfibkjfg3kd7xeiab/The-BEST-Homemade-Strawberry-Frosting-How-to-Make-Frosting.jpg?rlkey=bf76sh659ztvd9k0ja9e3skgi&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 74,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/f6u1lgfg24lkpnrxbvx5o/Banana-Caramel-Cupcakes-with-Caramel-Cream-Cheese-Frosting-Recipe.jpg?rlkey=rpxy5aotrpcgomkk3ysgjlgsi&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 75,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/053x0ximzu2wasdehukwj/Banana-Chocolate-Chip-Cupcakes-with-Cream-Cheese-Frosting-Cooking-Classy.jpg?rlkey=6i8d1ie5day2j5jo06m8ecfl4&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 76,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/8cw9phg2slso2c7ftbo3e/Banana-Cupcakes-Recipe-Sally-s-Baking-Addiction.jpg?rlkey=1dz9e1668tlf74pg74fnvzexl&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 77,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/9mysqrd34tyj67ito28bf/Banana-Cupcakes-with-Cream-Cheese-Frosting.jpg?rlkey=wghu1ojk398veztcb1u71xots&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 78,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/b4w74ejtsu4uorgukbcaz/Peanut-Butter-Banana-Cupcakes-The-Best-Cupcake-Recipe.jpg?rlkey=j3gjapl4dryk52da27stwcf75&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 79,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/v8f1b1dhgzcyafz992wxi/Banana-Cupcakes-with-Cream-Cheese-Frosting-1.jpg?rlkey=hn7vci8yio9zcoqdr2rjrjha1&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 80,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/c0id55usyvdtpvlm63zcu/Cannoli-Cupcakes.jpg?rlkey=w2ygc4vbl2mw83hdh198bhsw4&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 81,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/p27ytufvbm9kug9qajsmf/Chocolate-Cupcakes-with-Pistachios-and-Cognac-Buttercream-Frosting.jpg?rlkey=trwjtuu1ceapsexycd2x42kgf&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 82,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/mamd7esz4lxuy9b0jakef/Chocolate-Pistachio-Cupcakes.jpg?rlkey=q61pcchjfrcgv4fezbnvb04xg&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 83,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/jx92qgiganev8uyntueh8/Matcha-Green-Tea-Cupcakes.jpg?rlkey=8d4wwzk0dkpz0dsdoepnzahh8&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 84,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/n1ffp5xztnmggofptrd1k/Pistachio-Cupcakes-Recipe.jpg?rlkey=8xdf9rb9quxepq6sd7jb2w32x&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 85,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/3nlucly1o1epiequ8kw3q/Pistachio-Cupcakes-with-Orange-Mascarpone-Frosting.jpg?rlkey=3ph9ht9woaohnkzbrqkos8igv&dl=0");

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 86,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/z3mhkmgqvsc291wzy6pgv/Pistachio-Rosewater-Cupcakes-with-Saffron-Frosting.jpg?rlkey=dpeglysqx3dnqck5p6d5mpofn&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/jfl56ni9f5de2s3sqmhw0/umesh-soni-LDnmyOaA-ew-unsplash.jpg?rlkey=pr92cxu0uh1y7z7ex7ioxwjzu&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/rfl598aqnm0iiixeyebyi/Red-velvet-taart-bakken-recept.jpg?rlkey=tal1b51u3afcitj3bhc5yq7o8&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/xhi1yt8q88xxld4es6ulk/Copycat-Whole-Foods-Berry-Chantilly-Cake.jpg?rlkey=6z1qeif038wynl8e5sg4krzf0&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/q21mza82deuh2ilvgy99n/Dairy-Free-Lemon-Cake-Caked-by-Katie.jpg?rlkey=p6w64sedulhmhqpnehdh1wt0q&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h1wughcwngoiu4j2pwfpv/Tourte-aux-pommes-Apple-Pie-Dessert-classique-Am-ricain.jpg?rlkey=107amabi0pirjykgmn668cul6&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/h7tsp3bllbxmed9gfgvau/Homemade-Cherry-Pie-From-Scratch-House-of-Nash-Eats-1.jpg?rlkey=4cwitp3zz8vvvvdiyyko9h400&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/m8zwvnvpyt7o3y4qx22ye/Simply-the-Best-Blueberry-Pie-Recipe-Sally-s-Baking-Addiction-1.jpg?rlkey=lmu3n9nsxtj66y82lba9qpoeo&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/bza3ossr8ha2h223h566s/Sustainable-Eating.jpg?rlkey=8fgdqgaji17otjqvg53sqgdn6&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/6eqh8vkdin3x17hzh67vx/Caf-Mocha-Cupcakes-My-Baking-Addiction.jpg?rlkey=a7nym5zdy9koj6uyd6cbwqxw8&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/dpjrnn75f8nb99gy40f3m/Homemade-Strawberry-Cupcakes.jpg?rlkey=bwph5bf0rxzsxc9dn5s16rgq0&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/v8f1b1dhgzcyafz992wxi/Banana-Cupcakes-with-Cream-Cheese-Frosting-1.jpg?rlkey=hn7vci8yio9zcoqdr2rjrjha1&dl=0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/zop3gaf6hz6pwwp3mgho3/Pistachio-Green-Tea-Cupcakes-with-Matcha-Cream-Cheese-Frosting.jpg?rlkey=gs8rakwj4r28uu723tc9ny0kx&dl=0");
        }
    }
}
