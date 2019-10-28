using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using dataTier;

namespace Query
{
    public class controller
    {
        command cmd;
        public DataTable admin(string Admin, string Pass, string Akses)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new command();
                cmd.openCon();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@Admin", Admin));
                param.Add(new SqlParameter("@Pass", Pass));
                param.Add(new SqlParameter("@Akses", Akses));
                string query = @"SELECT *FROM [dbo].[tb_admin] where [Admin]=@Admin and [Pass]=@Pass and [Akses]=@Akses";
                dt = cmd.executeQuery(query, param);
                cmd.closeCon();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable getAdmin(string Akses)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new command();
                cmd.openCon();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@Akses", Akses));
                string query = @"SELECT Akses FROM [dbo].[tb_admin] where [Akses]=@Akses";
                dt = cmd.executeQuery(query, param);
                cmd.closeCon();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        public bool tmbahAdmin(string Admin, string Pass, string Akses)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@Admin", Admin));
                param.Add(new SqlParameter("@Pass", Pass));
                param.Add(new SqlParameter("@Akses", Akses));
                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_admin]
                                    ([Admin],[Pass],[Akses])
                                    VALUES
                                    (@Admin,@Pass,@Akses)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //PRODUK PEMBELI
        public DataTable getProdukPembeli(string keterangan)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            try
            {

                cmd.openCon();
                dt = cmd.executeQuery(@"select k.nama_kategori,b.nama_produk,b.gambar,b.harga_jual,b.kode_produk
                                        from tb_barang b inner join tb_kategori k on b.kode_kategori=k.kode_kategori
                                        where b.keterangan='" + keterangan + "'");
                cmd.closeCon();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //DATA CART

        public bool insertCart(string id_pembeli, string nama_produk, string gambar, int harga, int quantity, string warna, string ukuran, string status)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@id_pembeli", id_pembeli));
                param.Add(new SqlParameter("@nama_produk", nama_produk));
                param.Add(new SqlParameter("@gambar", gambar));
                param.Add(new SqlParameter("@harga", harga));
                param.Add(new SqlParameter("@quantity", quantity));
                param.Add(new SqlParameter("@warna", warna));
                param.Add(new SqlParameter("@ukuran", ukuran));
                param.Add(new SqlParameter("@status", status));
                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_cart]
                                    ([id_pembeli],[nama_produk],[gambar],[harga],[quantity],[warna],[ukuran],[status])
                                    VALUES
                                    (@id_pembeli,@nama_produk,@gambar.@harga,@quantity,@warna,@ukuran,@)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //Data KATEGORI

        public DataTable getKategori()
        {
            DataTable dt = new DataTable();
            cmd = new command();
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_kategori]");
            cmd.closeCon();
            return dt;
        }



        public DataTable getKategori(string kode_kategori)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@kode_kategori", kode_kategori));
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_kategori] WHERE [kode_kategori]=@kode_kategori", param);
            cmd.closeCon();
            return dt;
        }

        public bool insertKategori(string kode_kategori, string nama_kategori, string keterangan)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_kategori", kode_kategori));
                param.Add(new SqlParameter("@nama_kategori", nama_kategori));
                param.Add(new SqlParameter("@keterangan", keterangan));
                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_kategori]
                                    ([kode_kategori],[nama_kategori],[keterangan])
                                    VALUES
                                    (@kode_kategori,@nama_kategori,@keterangan)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public bool updateKategori(string kode_kategori, string nama_kategori, string keterangan)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_kategori", kode_kategori));
                param.Add(new SqlParameter("@nama_kategori", nama_kategori));
                param.Add(new SqlParameter("@keterangan", keterangan));
                cmd.openCon();
                cmd.executeNonquery(@"UPDATE [dbo].[tb_kategori]
                                    SET
                                    [kode_kategori] = @kode_kategori
                                    ,[nama_kategori] = @nama_kategori
                                    ,[keterangan] = @keterangan
                                    WHERE [kode_kategori]=@kode_kategori", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool deleteKategori(string kode_kategori)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_kategori", kode_kategori));
                cmd.openCon();
                cmd.executeNonquery(@"DELETE FROM [dbo].[tb_kategori] WHERE [kode_kategori]=@kode_kategori", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //DATA PRODUK
        public DataTable getProduk()
        {
            DataTable dt = new DataTable();
            cmd = new command();
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_barang]");
            cmd.closeCon();
            return dt;
        }

        public DataTable getProduk(string kode_produk)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@kode_produk", kode_produk));
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_barang] WHERE [kode_produk]=@kode_produk", param);
            cmd.closeCon();
            return dt;
        }

        public bool insertProduk(string kode_produk, string gambar, string kode_kategori, string nama_produk, int berat,string warna,string ukuran, int harga_jual, int stok_minimum, string keterangan)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                param.Add(new SqlParameter("@gambar", gambar));
                param.Add(new SqlParameter("@kode_kategori", kode_kategori));
                param.Add(new SqlParameter("@nama_produk", nama_produk));
                param.Add(new SqlParameter("@berat", berat));
                param.Add(new SqlParameter("@warna", warna));
                param.Add(new SqlParameter("@ukuran", ukuran));
                param.Add(new SqlParameter("@harga_jual", harga_jual));
                param.Add(new SqlParameter("@stok_minimum", stok_minimum));
                param.Add(new SqlParameter("@keterangan", keterangan));
                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_barang]
                                    ([kode_produk],[gambar],[kode_kategori],[nama_produk],[berat],[warna],[ukuran],[harga_jual],[stok_minimum],[keterangan])
                                    VALUES
                                    (@kode_produk,@gambar,@kode_kategori,@nama_produk,@berat,@warna,@ukuran,@harga_jual,@stok_minimum,@keterangan)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool updateProduk(string kode_produk, string gambar, string kode_kategori, string nama_produk, int berat,string warna,string ukuran, int harga_jual, int stok_minimum, string keterangan)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                param.Add(new SqlParameter("@gambar", gambar));
                param.Add(new SqlParameter("@kode_kategori", kode_kategori));
                param.Add(new SqlParameter("@nama_produk", nama_produk));
                param.Add(new SqlParameter("@berat", berat));
                param.Add(new SqlParameter("@warna", warna));
                param.Add(new SqlParameter("@ukuran", ukuran));
                param.Add(new SqlParameter("@harga_jual", harga_jual));
                param.Add(new SqlParameter("@stok_minimum", stok_minimum));
                param.Add(new SqlParameter("@keterangan", keterangan));
                cmd.openCon();
                cmd.executeNonquery(@"UPDATE [dbo].[tb_barang]
                                    SET
                                    [kode_produk] = @kode_produk
                                    ,[gambar]=@gambar
                                    ,[kode_kategori] = @kode_kategori
                                    ,[nama_produk] = @nama_produk
                                    ,[berat]=@berat
                                    ,[warna]=@warna
                                    ,[ukuran]=@ukuran
                                    ,[harga_jual] = @harga_jual
                                    ,[stok_minimum] = @stok_minimum
                                    ,[keterangan] = @keterangan
                                    WHERE [kode_produk]=@kode_produk", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool deleteProduk(string kode_produk)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                cmd.openCon();
                cmd.executeNonquery(@"DELETE FROM [dbo].[tb_barang] WHERE [kode_produk]=@kode_produk", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //DATA STOK
        public DataTable getStok()
        {
            DataTable dt = new DataTable();
            cmd = new command();
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_stok]");
            cmd.closeCon();
            return dt;
        }

        public DataTable getStok(string kode_produk)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@kode_produk", kode_produk));
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_stok] WHERE [kode_produk]=@kode_produk", param);
            cmd.closeCon();
            return dt;
        }

        public bool insertStok(string kode_produk, int stok)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                param.Add(new SqlParameter("@stok", stok));

                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_stok]
                                    ([kode_produk],[stok])
                                    VALUES
                                    (@kode_produk,@stok)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool updateStok(string kode_produk, int stok)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                param.Add(new SqlParameter("@stok", stok));
                cmd.openCon();
                cmd.executeNonquery(@"UPDATE [dbo].[tb_stok]
                                    SET
                                    [kode_produk] = @kode_produk
                                    ,[stok] = @stok
                                    
                                    WHERE [kode_produk]=@kode_produk", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool deleteStok(string kode_produk)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                cmd.openCon();
                cmd.executeNonquery(@"DELETE FROM [dbo].[tb_stok] WHERE [kode_produk]=@kode_produk", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        //R E G I S T R A S I
        public bool registrasi(string nama, string username, string kode_kota, string no_telp, string alamat, string password,int count_cart)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@nama", nama));
                param.Add(new SqlParameter("@username", username));
                param.Add(new SqlParameter("@kode_kota", kode_kota));
                param.Add(new SqlParameter("@no_telp", no_telp));
                param.Add(new SqlParameter("@alamat", alamat));
                param.Add(new SqlParameter("@password", password));
                param.Add(new SqlParameter("@count_cart", count_cart));

                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_pembeli]
                                    ([nama],[username],[kode_kota],[no_telp],[alamat],[password],[count_cart])
                                    VALUES
                                    (@nama,@username,@kode_kota,@no_telp,@alamat,@password,@count_cart)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //L O G I N  P E M B E L I
        public DataTable logPembeli(string nama, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new command();
                cmd.openCon();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@nama", nama));
                param.Add(new SqlParameter("@Password", password));
                string query = @"SELECT [nama],[password] FROM [dbo].[tb_pembeli] where [nama]=@nama and [password]=@password";
                dt = cmd.executeQuery(query, param);
                cmd.closeCon();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //C A R T
        public DataTable getCart()
        {
            DataTable dt = new DataTable();
            cmd = new command();
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[tb_cart]");
            cmd.closeCon();
            return dt;
        }

        public DataTable coba()
        {
            DataTable dt = new DataTable();
            cmd = new command();
            cmd.openCon();
            dt = cmd.executeQuery(@"SELECT *FROM [dbo].[coba]");
            cmd.closeCon();
            return dt;
        }
        public DataTable Cartt(string nama,string password)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new command();
                cmd.openCon();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@nama", nama));
                param.Add(new SqlParameter("@password", password));
                string query = @"select [count_cart] from [dbo].[tb_pembeli] where [nama]=@nama and [password]=@password";
                dt = cmd.executeQuery(query, param);
                cmd.closeCon();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool insertCart(string id_pembeli,string kode_produk, string nama_produk,string gambar, int quantity, string warna, string ukuran,string status)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@id_pembeli", id_pembeli));
                param.Add(new SqlParameter("@kode_produk", kode_produk));
                param.Add(new SqlParameter("@nama_produk", nama_produk));
                param.Add(new SqlParameter("@gambar", gambar));
                param.Add(new SqlParameter("@quantity", quantity));
                param.Add(new SqlParameter("@warna", warna));
                param.Add(new SqlParameter("@ukuran", ukuran));
                param.Add(new SqlParameter("@status", status));
                cmd.openCon();
                cmd.executeNonquery(@"INSERT INTO [dbo].[tb_cart]
                                    ([id_pembeli],[kode_produk],[nama_produk],[gambar],[quantity],[warna],[ukuran],[status])
                                    VALUES
                                    (@id_pembeli,@kode_produk,@nama_produk,@gambar,@quantity,@warna,@ukuran,@status)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool updateCart(string nama,string password, int count_cart)
        {
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@nama", nama));
                param.Add(new SqlParameter("@password", password));
                param.Add(new SqlParameter("@count_cart", count_cart));
                cmd.openCon();
                cmd.executeNonquery(@"UPDATE [dbo].[tb_pembeli]
                                    SET
                                    [count_cart] = @count_cart
                                    WHERE [nama]=@nama and [password]=@password", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable getProf(string nama, string password)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            try
            {

                cmd.openCon();
                dt = cmd.executeQuery(@"select p.nama,p.alamat,k.kota,p.no_telp
                                        from tb_pembeli p inner join tb_kota k on p.kode_kota=k.kode_kota
                                        where p.nama='" + nama + "' and p.password='"+password+"'");
                cmd.closeCon();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //C E C K  O U T
        public DataTable ceckOut(string id_pembeli)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            try
            {

                cmd.openCon();
                dt = cmd.executeQuery(@"select p.nama_produk,b.harga_jual
                                        from tb_cart p inner join tb_barang b on p.kode_produk=b.kode_produk
                                        where p.id_pembeli='"+id_pembeli+"'");
                cmd.closeCon();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable countCeck(string id_pembeli)
        {
            DataTable dt = new DataTable();
            cmd = new command();
            try
            {

                cmd.openCon();
                dt = cmd.executeQuery(@"select sum (b.harga_jual) as total
                                        from tb_barang b inner join tb_cart c on b.kode_produk=c.kode_produk
                                        where c.id_pembeli='" + id_pembeli + "'");
                cmd.closeCon();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool inPembayaran(string id_pembeli, int total_pembayaran,string kode_pembayaran,string status_pembayaran)
        {
            
            try
            {
                cmd = new command();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@id_pembeli", id_pembeli));
                param.Add(new SqlParameter("@total_pembayaran", total_pembayaran));
                param.Add(new SqlParameter("@kode_pembayaran", kode_pembayaran));
                param.Add(new SqlParameter("@status_pembayaran", status_pembayaran));
                cmd.openCon();
                cmd.executeQuery(@"INSERT INTO [dbo].[tb_pembayaran]
                                    ([id_pembeli],[total_pembayaran],[kode_pembayaran],[status_pembayaran])
                                    VALUES
                                    (@id_pembeli,@total_pembayaran,@kode_pembayaran,@status_pembayaran)", param);
                cmd.closeCon();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
