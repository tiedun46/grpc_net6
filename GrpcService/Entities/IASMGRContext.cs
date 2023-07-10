using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrpcService.Entities
{
    public partial class IASMGRContext : DbContext
    {
        public IASMGRContext()
        {
        }

        public IASMGRContext(DbContextOptions<IASMGRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TActivityLog> TActivityLogs { get; set; } = null!;
        public virtual DbSet<TAdministrativeUnit> TAdministrativeUnits { get; set; } = null!;
        public virtual DbSet<TBranch> TBranches { get; set; } = null!;
        public virtual DbSet<TClass> TClasses { get; set; } = null!;
        public virtual DbSet<TClassesCustomer> TClassesCustomers { get; set; } = null!;
        public virtual DbSet<TContact> TContacts { get; set; } = null!;
        public virtual DbSet<TCustomer> TCustomers { get; set; } = null!;
        public virtual DbSet<TCustomerAttr> TCustomerAttrs { get; set; } = null!;
        public virtual DbSet<TLicense> TLicenses { get; set; } = null!;
        public virtual DbSet<TLicenseRelationship> TLicenseRelationships { get; set; } = null!;
        public virtual DbSet<TOrganization> TOrganizations { get; set; } = null!;
        public virtual DbSet<TParentOrganization> TParentOrganizations { get; set; } = null!;
        public virtual DbSet<TProduct> TProducts { get; set; } = null!;
        public virtual DbSet<TProductUpdate> TProductUpdates { get; set; } = null!;
        public virtual DbSet<TProductUpdateTProduct> TProductUpdateTProducts { get; set; } = null!;
        public virtual DbSet<TWebCredential> TWebCredentials { get; set; } = null!;
        public virtual DbSet<TWebCredentialsAuthorization> TWebCredentialsAuthorizations { get; set; } = null!;
        public virtual DbSet<TWebDeploymentUrl> TWebDeploymentUrls { get; set; } = null!;
        public virtual DbSet<TWebServiceResource> TWebServiceResources { get; set; } = null!;
        public virtual DbSet<TWebServiceRole> TWebServiceRoles { get; set; } = null!;
        public virtual DbSet<TWebServiceRoleResource> TWebServiceRoleResources { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DUNGCOOL\\SQLEXPRESS;Database=IASMGR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TActivityLog>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tActivityLog");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogDescription).HasMaxLength(500);

                entity.Property(e => e.LogType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MetaCpuname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Meta_CPUName")
                    .IsSparse();

                entity.Property(e => e.MetaDbversion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Meta_DBVersion")
                    .IsSparse();

                entity.Property(e => e.MetaFileVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Meta_FileVersion")
                    .IsSparse();

                entity.Property(e => e.MetaIpaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Meta_IPAddress");

                entity.Property(e => e.MetaLicenseId).HasColumnName("Meta_LicenseID");

                entity.Property(e => e.MetaNetVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Meta_NetVersion")
                    .IsSparse();

                entity.Property(e => e.MetaOsversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Meta_OSVersion")
                    .IsSparse();

                entity.Property(e => e.MetaRamSize)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Meta_RamSize")
                    .IsSparse();

                entity.Property(e => e.MetaSessionId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Meta_SessionID")
                    .IsSparse();

                entity.Property(e => e.MetaSystemType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Meta_SystemType")
                    .IsSparse();

                entity.Property(e => e.MetaUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Username")
                    .IsSparse();
            });

            modelBuilder.Entity<TAdministrativeUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tAdministrativeUnits");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.IddonViCha).HasColumnName("IDDonViCha");

                entity.Property(e => e.MaDonVi).HasMaxLength(200);

                entity.Property(e => e.MaDonViCha).HasMaxLength(200);

                entity.Property(e => e.MaHuyen).HasMaxLength(50);

                entity.Property(e => e.MaThon).HasMaxLength(50);

                entity.Property(e => e.MaTinh).HasMaxLength(50);

                entity.Property(e => e.MaVung).HasMaxLength(50);

                entity.Property(e => e.MaVungKinhTeTrongDiem).HasMaxLength(200);

                entity.Property(e => e.MaXa).HasMaxLength(50);

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.Ten).HasMaxLength(200);

                entity.Property(e => e.XaMienNuiKv1).HasColumnName("XaMienNuiKV1");

                entity.Property(e => e.XaMienNuiKv2).HasColumnName("XaMienNuiKV2");

                entity.Property(e => e.XaMienNuiKv3).HasColumnName("XaMienNuiKV3");

                entity.HasOne(d => d.IddonViChaNavigation)
                    .WithMany(p => p.InverseIddonViChaNavigation)
                    .HasForeignKey(d => d.IddonViCha)
                    .HasConstraintName("FK_tAdministrativeUnits_IDDonViCha");
            });

            modelBuilder.Entity<TBranch>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatBranch_PK")
                    .IsClustered(false);

                entity.ToTable("tBranch");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchDescription).HasColumnType("ntext");

                entity.Property(e => e.BranchFullName).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .HasColumnName("BranchID");

                entity.Property(e => e.BranchName).HasMaxLength(100);

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");
            });

            modelBuilder.Entity<TClass>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatClass_PK")
                    .IsClustered(false);

                entity.ToTable("tClass");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClassDescription).HasColumnType("ntext");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .HasColumnName("ClassID");

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Forganization)
                    .HasColumnName("FOrganization")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Fproduct)
                    .HasColumnName("FProduct")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ForganizationNavigation)
                    .WithMany(p => p.TClasses)
                    .HasForeignKey(d => d.Forganization)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tClass_FK00");

                entity.HasOne(d => d.FproductNavigation)
                    .WithMany(p => p.TClasses)
                    .HasForeignKey(d => d.Fproduct)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tClass_FK01");
            });

            modelBuilder.Entity<TClassesCustomer>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatClasses_Customers_PK")
                    .IsClustered(false);

                entity.ToTable("tClasses_Customers");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Classes).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Customers).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ClassesNavigation)
                    .WithMany(p => p.TClassesCustomers)
                    .HasForeignKey(d => d.Classes)
                    .HasConstraintName("tClasses_Customers_FK00");

                entity.HasOne(d => d.CustomersNavigation)
                    .WithMany(p => p.TClassesCustomers)
                    .HasForeignKey(d => d.Customers)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tClasses_Customers_FK01");
            });

            modelBuilder.Entity<TContact>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatContact_PK")
                    .IsClustered(false);

                entity.ToTable("tContact");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.Address1).HasColumnType("ntext");

                entity.Property(e => e.ContactDescription).HasColumnType("ntext");

                entity.Property(e => e.ContactId)
                    .HasMaxLength(50)
                    .HasColumnName("ContactID");

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fcustomer)
                    .HasColumnName("FCustomer")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Forganization)
                    .HasColumnName("FOrganization")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.HasOne(d => d.FcustomerNavigation)
                    .WithMany(p => p.TContacts)
                    .HasForeignKey(d => d.Fcustomer)
                    .HasConstraintName("tContact_FK00");

                entity.HasOne(d => d.ForganizationNavigation)
                    .WithMany(p => p.TContacts)
                    .HasForeignKey(d => d.Forganization)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tContact_FK01");
            });

            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatCustomer_PK")
                    .IsClustered(false);

                entity.ToTable("tCustomer");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CmanagementLevel)
                    .HasMaxLength(100)
                    .HasColumnName("CManagementLevel");

                entity.Property(e => e.CmanagementRole)
                    .HasMaxLength(100)
                    .HasColumnName("CManagementRole");

                entity.Property(e => e.CorganizationLevel)
                    .HasMaxLength(100)
                    .HasColumnName("COrganizationLevel");

                entity.Property(e => e.CpublicPrivate)
                    .HasMaxLength(100)
                    .HasColumnName("CPublicPrivate");

                entity.Property(e => e.CredentialFormat).HasMaxLength(100);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FadministrativeUnit).HasColumnName("FAdministrativeUnit");

                entity.Property(e => e.Forganization)
                    .HasColumnName("FOrganization")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Fsuperior).HasColumnName("FSuperior");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.MaskedOid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.HasOne(d => d.FadministrativeUnitNavigation)
                    .WithMany(p => p.TCustomers)
                    .HasForeignKey(d => d.FadministrativeUnit)
                    .HasConstraintName("FK_tCustomer_FAdministrativeUnit");

                entity.HasOne(d => d.ForganizationNavigation)
                    .WithMany(p => p.TCustomers)
                    .HasForeignKey(d => d.Forganization)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tCustomer_FK00");

                entity.HasOne(d => d.FsuperiorNavigation)
                    .WithMany(p => p.InverseFsuperiorNavigation)
                    .HasForeignKey(d => d.Fsuperior)
                    .HasConstraintName("FK_tCustomer_FSuperior");
            });

            modelBuilder.Entity<TCustomerAttr>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tCustomerAttr");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AttrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttrValue).HasMaxLength(100);

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Fcustomer).HasColumnName("FCustomer");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.HasOne(d => d.FcustomerNavigation)
                    .WithMany(p => p.TCustomerAttrs)
                    .HasForeignKey(d => d.Fcustomer)
                    .HasConstraintName("FK_tCustomerAttr_tCustomer");
            });

            modelBuilder.Entity<TLicense>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatLicense_PK")
                    .IsClustered(false);

                entity.ToTable("tLicense");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DLastActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dLastActivityDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Fcustomer)
                    .HasColumnName("FCustomer")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Fproduct)
                    .HasColumnName("FProduct")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActivated)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDtmoduleGranted).HasColumnName("IsDTModuleGranted");

                entity.Property(e => e.IsNsmoduleGranted).HasColumnName("IsNSModuleGranted");

                entity.Property(e => e.LicenseCode).HasMaxLength(100);

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(100)
                    .HasColumnName("LicenseID");

                entity.Property(e => e.LicenseName).HasMaxLength(200);

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.MaskedOid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Orgname)
                    .HasMaxLength(100)
                    .HasColumnName("ORGName");

                entity.Property(e => e.Orgname2)
                    .HasMaxLength(100)
                    .HasColumnName("ORGName2");

                entity.Property(e => e.SLastSeenCpuname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenCPUName");

                entity.Property(e => e.SLastSeenDbversion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenDBVersion");

                entity.Property(e => e.SLastSeenFileVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenFileVersion");

                entity.Property(e => e.SLastSeenIpaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenIPAddress");

                entity.Property(e => e.SLastSeenNetVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenNetVersion");

                entity.Property(e => e.SLastSeenOsversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenOSVersion");

                entity.Property(e => e.SLastSeenRamSize)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenRamSize");

                entity.Property(e => e.SLastSeenSystemType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("sLastSeenSystemType");

                entity.HasOne(d => d.FcustomerNavigation)
                    .WithMany(p => p.TLicenses)
                    .HasForeignKey(d => d.Fcustomer)
                    .HasConstraintName("tLicense_FK00");

                entity.HasOne(d => d.FproductNavigation)
                    .WithMany(p => p.TLicenses)
                    .HasForeignKey(d => d.Fproduct)
                    .HasConstraintName("tLicense_FK01");
            });

            modelBuilder.Entity<TLicenseRelationship>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tLicenseRelationship");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ChildLicenseId).HasColumnName("ChildLicenseID");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.IPermission).HasColumnName("iPermission");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.ParentLicenseId).HasColumnName("ParentLicenseID");

                entity.HasOne(d => d.ChildLicense)
                    .WithMany(p => p.TLicenseRelationshipChildLicenses)
                    .HasForeignKey(d => d.ChildLicenseId)
                    .HasConstraintName("FK_tLicenseRelationship_ChildLicense");

                entity.HasOne(d => d.ParentLicense)
                    .WithMany(p => p.TLicenseRelationshipParentLicenses)
                    .HasForeignKey(d => d.ParentLicenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLicenseRelationship_ParentLicense");
            });

            modelBuilder.Entity<TOrganization>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatOrganization_PK")
                    .IsClustered(false);

                entity.ToTable("tOrganization");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.Address2).HasColumnType("ntext");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.FadministrativeUnit).HasColumnName("FAdministrativeUnit");

                entity.Property(e => e.FparentOrganization).HasColumnName("FParentOrganization");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.OrganizationId)
                    .HasMaxLength(50)
                    .HasColumnName("OrganizationID");

                entity.Property(e => e.OrganizationName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.HasOne(d => d.FadministrativeUnitNavigation)
                    .WithMany(p => p.TOrganizations)
                    .HasForeignKey(d => d.FadministrativeUnit)
                    .HasConstraintName("FK_tOrganization_FAdministrativeUnit");

                entity.HasOne(d => d.FparentOrganizationNavigation)
                    .WithMany(p => p.TOrganizations)
                    .HasForeignKey(d => d.FparentOrganization)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tOrganization_FParentOrganization");
            });

            modelBuilder.Entity<TParentOrganization>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tParentOrganization");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.FadministrativeUnit).HasColumnName("FAdministrativeUnit");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.OrganizationId)
                    .HasMaxLength(50)
                    .HasColumnName("OrganizationID");

                entity.Property(e => e.OrganizationName).HasMaxLength(100);

                entity.HasOne(d => d.FadministrativeUnitNavigation)
                    .WithMany(p => p.TParentOrganizations)
                    .HasForeignKey(d => d.FadministrativeUnit)
                    .HasConstraintName("FK_tParentOrganization_FAdministrativeUnit");
            });

            modelBuilder.Entity<TProduct>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("aaaaatProduct_PK")
                    .IsClustered(false);

                entity.ToTable("tProduct");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Fbranch)
                    .HasColumnName("FBranch")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.ProductDescription).HasColumnType("ntext");

                entity.Property(e => e.ProductFullName).HasMaxLength(100);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ProductVersion).HasMaxLength(50);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.StatisticsEnabled).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FbranchNavigation)
                    .WithMany(p => p.TProducts)
                    .HasForeignKey(d => d.Fbranch)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tProduct_FK00");
            });

            modelBuilder.Entity<TProductUpdate>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tProductUpdate");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DownloadUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateName).HasMaxLength(100);

                entity.Property(e => e.Version).HasMaxLength(100);

                entity.Property(e => e.VoidReason).HasMaxLength(100);
            });

            modelBuilder.Entity<TProductUpdateTProduct>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_tProductUpdatetProductUpdates_tProducttProducts");

                entity.ToTable("tProductUpdate_tProducts");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("OID");

                entity.Property(e => e.TProductUpdates).HasColumnName("tProductUpdates");

                entity.Property(e => e.TProducts).HasColumnName("tProducts");

                entity.HasOne(d => d.TProductUpdatesNavigation)
                    .WithMany(p => p.TProductUpdateTProducts)
                    .HasForeignKey(d => d.TProductUpdates)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tProductUpdatetProductUpdates_tProducttProducts_tProductUpdates");

                entity.HasOne(d => d.TProductsNavigation)
                    .WithMany(p => p.TProductUpdateTProducts)
                    .HasForeignKey(d => d.TProducts)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tProductUpdatetProductUpdates_tProducttProducts_tProducts");
            });

            modelBuilder.Entity<TWebCredential>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tWebCredentials");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActivationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DLastActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dLastActivityDate");

                entity.Property(e => e.DLastPasswordChangedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dLastPasswordChangedDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Fcustomer).HasColumnName("FCustomer");

                entity.Property(e => e.Fullname).HasMaxLength(200);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a753c776ff3ed4fefa2af948af87448910153281')");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.FcustomerNavigation)
                    .WithMany(p => p.TWebCredentials)
                    .HasForeignKey(d => d.Fcustomer)
                    .HasConstraintName("FK_tWebCredentials_tCustomer");
            });

            modelBuilder.Entity<TWebCredentialsAuthorization>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tWebCredentialsAuthorization");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.Roles)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.WebCredentialsNavigation)
                    .WithMany(p => p.TWebCredentialsAuthorizations)
                    .HasForeignKey(d => d.WebCredentials)
                    .HasConstraintName("FK_tWebCredentialsAuthorization_WebCredentials");

                entity.HasOne(d => d.WebDeploymentsNavigation)
                    .WithMany(p => p.TWebCredentialsAuthorizations)
                    .HasForeignKey(d => d.WebDeployments)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tWebCredentialsAuthorization_tLicense");
            });

            modelBuilder.Entity<TWebDeploymentUrl>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tWebDeploymentUrls");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Flicense).HasColumnName("FLicense");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.ServiceUrlAddress).HasMaxLength(200);

                entity.Property(e => e.UrlAddress).HasMaxLength(200);

                entity.HasOne(d => d.FlicenseNavigation)
                    .WithMany(p => p.TWebDeploymentUrls)
                    .HasForeignKey(d => d.Flicense)
                    .HasConstraintName("FK_tWebDeploymentUrls_tLicense");
            });

            modelBuilder.Entity<TWebServiceResource>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_tWebServiceFunctions");

                entity.ToTable("tWebServiceResources");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Fproduct).HasColumnName("FProduct");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.WebServiceResourceId)
                    .HasMaxLength(50)
                    .HasColumnName("WebServiceResourceID");

                entity.Property(e => e.WebServiceResourceName).HasMaxLength(100);

                entity.HasOne(d => d.FproductNavigation)
                    .WithMany(p => p.TWebServiceResources)
                    .HasForeignKey(d => d.Fproduct)
                    .HasConstraintName("FK_tWebServiceResources_tProduct");
            });

            modelBuilder.Entity<TWebServiceRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tWebServiceRoles");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.Fproduct).HasColumnName("FProduct");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.WebServiceRoleId)
                    .HasMaxLength(50)
                    .HasColumnName("WebServiceRoleID");

                entity.Property(e => e.WebServiceRoleName).HasMaxLength(100);

                entity.HasOne(d => d.FproductNavigation)
                    .WithMany(p => p.TWebServiceRoles)
                    .HasForeignKey(d => d.Fproduct)
                    .HasConstraintName("FK_tWebServiceRoles_tProduct");
            });

            modelBuilder.Entity<TWebServiceRoleResource>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tWebServiceRoleResource");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DInputDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dInputDate");

                entity.Property(e => e.DValidUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dValidUntilDate");

                entity.Property(e => e.FwebServiceResource).HasColumnName("FWebServiceResource");

                entity.Property(e => e.FwebServiceRole).HasColumnName("FWebServiceRole");

                entity.Property(e => e.IPermission).HasColumnName("iPermission");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.HasOne(d => d.FwebServiceResourceNavigation)
                    .WithMany(p => p.TWebServiceRoleResources)
                    .HasForeignKey(d => d.FwebServiceResource)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tWebServiceRoleResource_FWebServiceResource");

                entity.HasOne(d => d.FwebServiceRoleNavigation)
                    .WithMany(p => p.TWebServiceRoleResources)
                    .HasForeignKey(d => d.FwebServiceRole)
                    .HasConstraintName("FK_tWebServiceRoleResource_FWebServiceRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
