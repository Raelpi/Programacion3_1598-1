using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion1201
{
    public class BaseDatos
    {
       readonly string cadena = "Data Source=DESKTOP-U0HG9P9\\SQLEXPRESS15; Initial Catalog=FACTURACION1201; User ID=sa; Password=geografia";
    
       public  bool validarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIOS WHERE CODIGO = @Codigo AND CLAVE = @Clave AND ESTAACTIVO = 1 ; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using(SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;

                        EsUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception)
            {
            
            }
            return EsUsuarioValido;
        }

       

        public DataTable CargarCategorias()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CATEGORIAS ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using(SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch(Exception)
            {

            }
            return dt;
        }

        public bool InsertarProducto(string codigo , string descripcion, int idcategoria,decimal precio, int existencia , byte[] imagen)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO PRODUCTOS ");
                sql.Append("VALUES (@Codigo, @Descripcion, @IdCategoria, @Precio, @Existencia, @Imagen); ");

                using(SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using(SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = descripcion;
                        comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idcategoria;
                        comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
                        comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
   
        public DataTable ListarProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT P.CODIGO,P.DESCRIPCION, C.DESCRIPCION CATEGORIA,P.PRECIO,P.EXISTENCIA ");
                sql.Append(" from PRODUCTOS P ");
                sql.Append(" INNER JOIN CATEGORIAS C ON  C.ID = P.IDCATEGORIA ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public bool EditarProductos(string codigo, string descripcion, int idcategoria, decimal precio, int existencia)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE PRODUCTOS ");
                sql.Append(" SET DESCRIPCION = @Descripcion, IDCATEGORIA =  @IdCategoria, PRECIO = @Precio , EXISTENCIA = @Existencia ");
                sql.Append(" WHERE CODIGO = @Codigo ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = descripcion;
                        comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = idcategoria;
                        comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    
        public byte[] SeleccionarImagenProductos(string codigo)
        {
            byte[] _image = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT IMAGEN FROM PRODUCTOS ");
                sql.Append(" WHERE CODIGO = @Codigo ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        SqlDataReader dr = comando.ExecuteReader();
                        if(dr.Read())
                        {
                            _image = (byte[])dr["IMAGEN"];
                        }
                    }
                }
            }
            catch (Exception)
            {
               
            }
            return _image;
        }

        public bool Eliminarproducto(string codigo)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM PRODUCTOS ");
                sql.Append(" WHERE CODIGO = @Codigo ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertarUsuario(string codigo, string nombre , string clave)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO USUARIOS ");
                sql.Append(" VALUES (@Codigo, @Clave, @Nombre, EstaActivo); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;
                        comando.Parameters.Add("@EstaActivo", SqlDbType.Bit).Value = true;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarUsuario(string codigo, string nombre, string clave, bool estado)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE USUARIOS ");
                sql.Append(" SET NOMBRE = @Nombre, CLAVE =  @Clave, ESTAACTIVO = @EstaActivo ");
                sql.Append(" WHERE CODIGO = @Codigo ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;
                        comando.Parameters.Add("@EstaActivo", SqlDbType.Bit).Value = estado;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable SeleccionarUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT CODIGO, NOMBRE, CLAVE, ESTAACTIVO FROM USUARIOS ");
                
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public bool EliminarUsuario(string codigo)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM USUARIOS ");
                sql.Append(" WHERE CODIGO = @Codigo ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
