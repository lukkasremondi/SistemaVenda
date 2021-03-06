﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistema.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_sistema")]
	public partial class sistemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    partial void InsertVenda(Venda instance);
    partial void UpdateVenda(Venda instance);
    partial void DeleteVenda(Venda instance);
    partial void InsertPessoas(Pessoas instance);
    partial void UpdatePessoas(Pessoas instance);
    partial void DeletePessoas(Pessoas instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void InsertIntensVenda(IntensVenda instance);
    partial void UpdateIntensVenda(IntensVenda instance);
    partial void DeleteIntensVenda(IntensVenda instance);
    partial void InsertPonto(Ponto instance);
    partial void UpdatePonto(Ponto instance);
    partial void DeletePonto(Ponto instance);
    #endregion
		
		public sistemaDataContext() : 
				base(global::sistema.DAL.Properties.Settings.Default.db_sistemaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categorias
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Produto> Produtos
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
		
		public System.Data.Linq.Table<Venda> Vendas
		{
			get
			{
				return this.GetTable<Venda>();
			}
		}
		
		public System.Data.Linq.Table<Pessoas> Pessoas
		{
			get
			{
				return this.GetTable<Pessoas>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<IntensVenda> IntensVendas
		{
			get
			{
				return this.GetTable<IntensVenda>();
			}
		}
		
		public System.Data.Linq.Table<Ponto> Pontos
		{
			get
			{
				return this.GetTable<Ponto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private EntitySet<Produto> _Produtos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    #endregion
		
		public Categoria()
		{
			this._Produtos = new EntitySet<Produto>(new Action<Produto>(this.attach_Produtos), new Action<Produto>(this.detach_Produtos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_categoria", Storage="_Descricao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Produto", Storage="_Produtos", ThisKey="Codigo", OtherKey="CodigoCategoria")]
		public EntitySet<Produto> Produtos
		{
			get
			{
				return this._Produtos;
			}
			set
			{
				this._Produtos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_produto")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private decimal _Valor;
		
		private int _CodigoCategoria;
		
		private EntitySet<IntensVenda> _IntensVendas;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnValorChanging(decimal value);
    partial void OnValorChanged();
    partial void OnCodigoCategoriaChanging(int value);
    partial void OnCodigoCategoriaChanged();
    #endregion
		
		public Produto()
		{
			this._IntensVendas = new EntitySet<IntensVenda>(new Action<IntensVenda>(this.attach_IntensVendas), new Action<IntensVenda>(this.detach_IntensVendas));
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_produto", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_produto", Storage="_Descricao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="valor", Storage="_Valor", DbType="Decimal(25,2) NOT NULL")]
		public decimal Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._Valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_CodigoCategoria", DbType="Int NOT NULL")]
		public int CodigoCategoria
		{
			get
			{
				return this._CodigoCategoria;
			}
			set
			{
				if ((this._CodigoCategoria != value))
				{
					this.OnCodigoCategoriaChanging(value);
					this.SendPropertyChanging();
					this._CodigoCategoria = value;
					this.SendPropertyChanged("CodigoCategoria");
					this.OnCodigoCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produto_IntensVenda", Storage="_IntensVendas", ThisKey="Codigo", OtherKey="CodigoProduto")]
		public EntitySet<IntensVenda> IntensVendas
		{
			get
			{
				return this._IntensVendas;
			}
			set
			{
				this._IntensVendas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Produto", Storage="_Categoria", ThisKey="CodigoCategoria", OtherKey="Codigo", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Produtos.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Produtos.Add(this);
						this._CodigoCategoria = value.Codigo;
					}
					else
					{
						this._CodigoCategoria = default(int);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_IntensVendas(IntensVenda entity)
		{
			this.SendPropertyChanging();
			entity.Produto = this;
		}
		
		private void detach_IntensVendas(IntensVenda entity)
		{
			this.SendPropertyChanging();
			entity.Produto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_venda")]
	public partial class Venda : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodigoVenda;
		
		private System.Nullable<decimal> _Valor;
		
		private System.Nullable<decimal> _Desconto;
		
		private System.Nullable<decimal> _ValorPago;
		
		private System.Nullable<int> _CodigoPessoa;
		
		private EntitySet<IntensVenda> _IntensVendas;
		
		private EntityRef<Pessoas> _Pessoas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoVendaChanging(int value);
    partial void OnCodigoVendaChanged();
    partial void OnValorChanging(System.Nullable<decimal> value);
    partial void OnValorChanged();
    partial void OnDescontoChanging(System.Nullable<decimal> value);
    partial void OnDescontoChanged();
    partial void OnValorPagoChanging(System.Nullable<decimal> value);
    partial void OnValorPagoChanged();
    partial void OnCodigoPessoaChanging(System.Nullable<int> value);
    partial void OnCodigoPessoaChanged();
    #endregion
		
		public Venda()
		{
			this._IntensVendas = new EntitySet<IntensVenda>(new Action<IntensVenda>(this.attach_IntensVendas), new Action<IntensVenda>(this.detach_IntensVendas));
			this._Pessoas = default(EntityRef<Pessoas>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_venda", Storage="_CodigoVenda", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodigoVenda
		{
			get
			{
				return this._CodigoVenda;
			}
			set
			{
				if ((this._CodigoVenda != value))
				{
					this.OnCodigoVendaChanging(value);
					this.SendPropertyChanging();
					this._CodigoVenda = value;
					this.SendPropertyChanged("CodigoVenda");
					this.OnCodigoVendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="valor", Storage="_Valor", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._Valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desconto", Storage="_Desconto", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> Desconto
		{
			get
			{
				return this._Desconto;
			}
			set
			{
				if ((this._Desconto != value))
				{
					this.OnDescontoChanging(value);
					this.SendPropertyChanging();
					this._Desconto = value;
					this.SendPropertyChanged("Desconto");
					this.OnDescontoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="valor_pago", Storage="_ValorPago", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> ValorPago
		{
			get
			{
				return this._ValorPago;
			}
			set
			{
				if ((this._ValorPago != value))
				{
					this.OnValorPagoChanging(value);
					this.SendPropertyChanging();
					this._ValorPago = value;
					this.SendPropertyChanged("ValorPago");
					this.OnValorPagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_pessoa", Storage="_CodigoPessoa", DbType="Int")]
		public System.Nullable<int> CodigoPessoa
		{
			get
			{
				return this._CodigoPessoa;
			}
			set
			{
				if ((this._CodigoPessoa != value))
				{
					this.OnCodigoPessoaChanging(value);
					this.SendPropertyChanging();
					this._CodigoPessoa = value;
					this.SendPropertyChanged("CodigoPessoa");
					this.OnCodigoPessoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venda_IntensVenda", Storage="_IntensVendas", ThisKey="CodigoVenda", OtherKey="CodigoVenda")]
		public EntitySet<IntensVenda> IntensVendas
		{
			get
			{
				return this._IntensVendas;
			}
			set
			{
				this._IntensVendas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pessoas_Venda", Storage="_Pessoas", ThisKey="CodigoPessoa", OtherKey="Codigo", IsForeignKey=true)]
		public Pessoas Pessoas
		{
			get
			{
				return this._Pessoas.Entity;
			}
			set
			{
				Pessoas previousValue = this._Pessoas.Entity;
				if (((previousValue != value) 
							|| (this._Pessoas.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pessoas.Entity = null;
						previousValue.Vendas.Remove(this);
					}
					this._Pessoas.Entity = value;
					if ((value != null))
					{
						value.Vendas.Add(this);
						this._CodigoPessoa = value.Codigo;
					}
					else
					{
						this._CodigoPessoa = default(Nullable<int>);
					}
					this.SendPropertyChanged("Pessoas");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_IntensVendas(IntensVenda entity)
		{
			this.SendPropertyChanging();
			entity.Venda = this;
		}
		
		private void detach_IntensVendas(IntensVenda entity)
		{
			this.SendPropertyChanging();
			entity.Venda = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_clientes")]
	public partial class Pessoas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private string _Telefone;
		
		private EntitySet<Venda> _Vendas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnTelefoneChanging(string value);
    partial void OnTelefoneChanged();
    #endregion
		
		public Pessoas()
		{
			this._Vendas = new EntitySet<Venda>(new Action<Venda>(this.attach_Vendas), new Action<Venda>(this.detach_Vendas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_pessoa", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="des_pessoa", Storage="_Descricao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="telefone", Storage="_Telefone", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Telefone
		{
			get
			{
				return this._Telefone;
			}
			set
			{
				if ((this._Telefone != value))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._Telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pessoas_Venda", Storage="_Vendas", ThisKey="Codigo", OtherKey="CodigoPessoa")]
		public EntitySet<Venda> Vendas
		{
			get
			{
				return this._Vendas;
			}
			set
			{
				this._Vendas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Vendas(Venda entity)
		{
			this.SendPropertyChanging();
			entity.Pessoas = this;
		}
		
		private void detach_Vendas(Venda entity)
		{
			this.SendPropertyChanging();
			entity.Pessoas = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_usuario")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Usuario;
		
		private string _Senha;
		
		private int _CodigoPessoa;
		
		private EntitySet<Ponto> _Pontos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnSenhaChanging(string value);
    partial void OnSenhaChanged();
    partial void OnCodigoPessoaChanging(int value);
    partial void OnCodigoPessoaChanged();
    #endregion
		
		public Usuarios()
		{
			this._Pontos = new EntitySet<Ponto>(new Action<Ponto>(this.attach_Pontos), new Action<Ponto>(this.detach_Pontos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="usuario", Storage="_Usuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="senha", Storage="_Senha", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Senha
		{
			get
			{
				return this._Senha;
			}
			set
			{
				if ((this._Senha != value))
				{
					this.OnSenhaChanging(value);
					this.SendPropertyChanging();
					this._Senha = value;
					this.SendPropertyChanged("Senha");
					this.OnSenhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_pessoa", Storage="_CodigoPessoa", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CodigoPessoa
		{
			get
			{
				return this._CodigoPessoa;
			}
			set
			{
				if ((this._CodigoPessoa != value))
				{
					this.OnCodigoPessoaChanging(value);
					this.SendPropertyChanging();
					this._CodigoPessoa = value;
					this.SendPropertyChanged("CodigoPessoa");
					this.OnCodigoPessoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_tb_registrodeponto", Storage="_Pontos", ThisKey="CodigoPessoa", OtherKey="id_pessoa")]
		public EntitySet<Ponto> Pontos
		{
			get
			{
				return this._Pontos;
			}
			set
			{
				this._Pontos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Pontos(Ponto entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = this;
		}
		
		private void detach_Pontos(Ponto entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_itens_venda")]
	public partial class IntensVenda : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Quantidade;
		
		private int _CodigoProduto;
		
		private int _CodigoVenda;
		
		private decimal _Valor;
		
		private int _CodigoItem;
		
		private EntityRef<Produto> _Produto;
		
		private EntityRef<Venda> _Venda;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuantidadeChanging(int value);
    partial void OnQuantidadeChanged();
    partial void OnCodigoProdutoChanging(int value);
    partial void OnCodigoProdutoChanged();
    partial void OnCodigoVendaChanging(int value);
    partial void OnCodigoVendaChanged();
    partial void OnValorChanging(decimal value);
    partial void OnValorChanged();
    partial void OnCodigoItemChanging(int value);
    partial void OnCodigoItemChanged();
    #endregion
		
		public IntensVenda()
		{
			this._Produto = default(EntityRef<Produto>);
			this._Venda = default(EntityRef<Venda>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="quantidade", Storage="_Quantidade", DbType="Int NOT NULL")]
		public int Quantidade
		{
			get
			{
				return this._Quantidade;
			}
			set
			{
				if ((this._Quantidade != value))
				{
					this.OnQuantidadeChanging(value);
					this.SendPropertyChanging();
					this._Quantidade = value;
					this.SendPropertyChanged("Quantidade");
					this.OnQuantidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_produto", Storage="_CodigoProduto", DbType="Int NOT NULL")]
		public int CodigoProduto
		{
			get
			{
				return this._CodigoProduto;
			}
			set
			{
				if ((this._CodigoProduto != value))
				{
					this.OnCodigoProdutoChanging(value);
					this.SendPropertyChanging();
					this._CodigoProduto = value;
					this.SendPropertyChanged("CodigoProduto");
					this.OnCodigoProdutoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_venda", Storage="_CodigoVenda", DbType="Int NOT NULL")]
		public int CodigoVenda
		{
			get
			{
				return this._CodigoVenda;
			}
			set
			{
				if ((this._CodigoVenda != value))
				{
					this.OnCodigoVendaChanging(value);
					this.SendPropertyChanging();
					this._CodigoVenda = value;
					this.SendPropertyChanged("CodigoVenda");
					this.OnCodigoVendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="valor", Storage="_Valor", DbType="Decimal(15,2) NOT NULL")]
		public decimal Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._Valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_item", Storage="_CodigoItem", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodigoItem
		{
			get
			{
				return this._CodigoItem;
			}
			set
			{
				if ((this._CodigoItem != value))
				{
					this.OnCodigoItemChanging(value);
					this.SendPropertyChanging();
					this._CodigoItem = value;
					this.SendPropertyChanged("CodigoItem");
					this.OnCodigoItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produto_IntensVenda", Storage="_Produto", ThisKey="CodigoProduto", OtherKey="Codigo", IsForeignKey=true)]
		public Produto Produto
		{
			get
			{
				return this._Produto.Entity;
			}
			set
			{
				Produto previousValue = this._Produto.Entity;
				if (((previousValue != value) 
							|| (this._Produto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produto.Entity = null;
						previousValue.IntensVendas.Remove(this);
					}
					this._Produto.Entity = value;
					if ((value != null))
					{
						value.IntensVendas.Add(this);
						this._CodigoProduto = value.Codigo;
					}
					else
					{
						this._CodigoProduto = default(int);
					}
					this.SendPropertyChanged("Produto");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venda_IntensVenda", Storage="_Venda", ThisKey="CodigoVenda", OtherKey="CodigoVenda", IsForeignKey=true)]
		public Venda Venda
		{
			get
			{
				return this._Venda.Entity;
			}
			set
			{
				Venda previousValue = this._Venda.Entity;
				if (((previousValue != value) 
							|| (this._Venda.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Venda.Entity = null;
						previousValue.IntensVendas.Remove(this);
					}
					this._Venda.Entity = value;
					if ((value != null))
					{
						value.IntensVendas.Add(this);
						this._CodigoVenda = value.CodigoVenda;
					}
					else
					{
						this._CodigoVenda = default(int);
					}
					this.SendPropertyChanged("Venda");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_registrodeponto")]
	public partial class Ponto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _Data;
		
		private string _Entrada;
		
		private string _Saida_almoco;
		
		private string _Retorno_almoco;
		
		private string _Saida;
		
		private int _id;
		
		private int _id_pessoa;
		
		private System.Nullable<System.DateTime> _modstamp;
		
		private System.Nullable<System.DateTime> _data_registro;
		
		private System.Nullable<System.DateTime> _Data_hj;
		
		private EntityRef<Usuarios> _Usuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDataChanging(System.DateTime value);
    partial void OnDataChanged();
    partial void OnEntradaChanging(string value);
    partial void OnEntradaChanged();
    partial void OnSaida_almocoChanging(string value);
    partial void OnSaida_almocoChanged();
    partial void OnRetorno_almocoChanging(string value);
    partial void OnRetorno_almocoChanged();
    partial void OnSaidaChanging(string value);
    partial void OnSaidaChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_pessoaChanging(int value);
    partial void Onid_pessoaChanged();
    partial void OnmodstampChanging(System.Nullable<System.DateTime> value);
    partial void OnmodstampChanged();
    partial void Ondata_registroChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_registroChanged();
    partial void OnData_hjChanging(System.Nullable<System.DateTime> value);
    partial void OnData_hjChanged();
    #endregion
		
		public Ponto()
		{
			this._Usuarios = default(EntityRef<Usuarios>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="data_reg", Storage="_Data", DbType="Date NOT NULL")]
		public System.DateTime Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="entrada", Storage="_Entrada", DbType="VarChar(5)")]
		public string Entrada
		{
			get
			{
				return this._Entrada;
			}
			set
			{
				if ((this._Entrada != value))
				{
					this.OnEntradaChanging(value);
					this.SendPropertyChanging();
					this._Entrada = value;
					this.SendPropertyChanged("Entrada");
					this.OnEntradaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="saida_almoco", Storage="_Saida_almoco", DbType="VarChar(5)")]
		public string Saida_almoco
		{
			get
			{
				return this._Saida_almoco;
			}
			set
			{
				if ((this._Saida_almoco != value))
				{
					this.OnSaida_almocoChanging(value);
					this.SendPropertyChanging();
					this._Saida_almoco = value;
					this.SendPropertyChanged("Saida_almoco");
					this.OnSaida_almocoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="retorno_almoco", Storage="_Retorno_almoco", DbType="VarChar(5)")]
		public string Retorno_almoco
		{
			get
			{
				return this._Retorno_almoco;
			}
			set
			{
				if ((this._Retorno_almoco != value))
				{
					this.OnRetorno_almocoChanging(value);
					this.SendPropertyChanging();
					this._Retorno_almoco = value;
					this.SendPropertyChanged("Retorno_almoco");
					this.OnRetorno_almocoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="saida", Storage="_Saida", DbType="VarChar(5)")]
		public string Saida
		{
			get
			{
				return this._Saida;
			}
			set
			{
				if ((this._Saida != value))
				{
					this.OnSaidaChanging(value);
					this.SendPropertyChanging();
					this._Saida = value;
					this.SendPropertyChanged("Saida");
					this.OnSaidaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pessoa", DbType="Int NOT NULL")]
		public int id_pessoa
		{
			get
			{
				return this._id_pessoa;
			}
			set
			{
				if ((this._id_pessoa != value))
				{
					if (this._Usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_pessoaChanging(value);
					this.SendPropertyChanging();
					this._id_pessoa = value;
					this.SendPropertyChanged("id_pessoa");
					this.Onid_pessoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modstamp", DbType="DateTime2")]
		public System.Nullable<System.DateTime> modstamp
		{
			get
			{
				return this._modstamp;
			}
			set
			{
				if ((this._modstamp != value))
				{
					this.OnmodstampChanging(value);
					this.SendPropertyChanging();
					this._modstamp = value;
					this.SendPropertyChanged("modstamp");
					this.OnmodstampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_registro", DbType="DateTime2")]
		public System.Nullable<System.DateTime> data_registro
		{
			get
			{
				return this._data_registro;
			}
			set
			{
				if ((this._data_registro != value))
				{
					this.Ondata_registroChanging(value);
					this.SendPropertyChanging();
					this._data_registro = value;
					this.SendPropertyChanged("data_registro");
					this.Ondata_registroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="data_hj", Storage="_Data_hj", DbType="DateTime2")]
		public System.Nullable<System.DateTime> Data_hj
		{
			get
			{
				return this._Data_hj;
			}
			set
			{
				if ((this._Data_hj != value))
				{
					this.OnData_hjChanging(value);
					this.SendPropertyChanging();
					this._Data_hj = value;
					this.SendPropertyChanged("Data_hj");
					this.OnData_hjChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_tb_registrodeponto", Storage="_Usuarios", ThisKey="id_pessoa", OtherKey="CodigoPessoa", IsForeignKey=true)]
		public Usuarios Usuarios
		{
			get
			{
				return this._Usuarios.Entity;
			}
			set
			{
				Usuarios previousValue = this._Usuarios.Entity;
				if (((previousValue != value) 
							|| (this._Usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuarios.Entity = null;
						previousValue.Pontos.Remove(this);
					}
					this._Usuarios.Entity = value;
					if ((value != null))
					{
						value.Pontos.Add(this);
						this._id_pessoa = value.CodigoPessoa;
					}
					else
					{
						this._id_pessoa = default(int);
					}
					this.SendPropertyChanged("Usuarios");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
