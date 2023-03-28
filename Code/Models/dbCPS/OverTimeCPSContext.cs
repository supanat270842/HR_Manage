using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HR_Management.Models.dbCPS
{
    public partial class OverTimeCPSContext : DbContext
    {
        public OverTimeCPSContext()
        {
        }

        public OverTimeCPSContext(DbContextOptions<OverTimeCPSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApproveOt> ApproveOts { get; set; } = null!;
        public virtual DbSet<ConfigCheckinTime> ConfigCheckinTimes { get; set; } = null!;
        public virtual DbSet<ConfigOt> ConfigOts { get; set; } = null!;
        public virtual DbSet<EmployeeOt> EmployeeOts { get; set; } = null!;
        public virtual DbSet<HeaderOt> HeaderOts { get; set; } = null!;
        public virtual DbSet<ItemOt> ItemOts { get; set; } = null!;
        public virtual DbSet<Otautorun> Otautoruns { get; set; } = null!;
        public virtual DbSet<ScanFile> ScanFiles { get; set; } = null!;
        public virtual DbSet<TransectionsCheckin> TransectionsCheckins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.99;Database=OverTimeCPS;User Id=sa;Password=dogthaiP@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Thai_CS_AS_KS_WS");

            modelBuilder.Entity<ApproveOt>(entity =>
            {
                entity.ToTable("ApproveOTs");

                entity.Property(e => e.ApproveOtid).HasColumnName("ApproveOTId");

                entity.Property(e => e.ApproveOtcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApproveOTCC");

                entity.Property(e => e.ApproveOtempId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApproveOTEmpId");

                entity.Property(e => e.ApproveOtempName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ApproveOTEmpName");

                entity.Property(e => e.ApproveOtplant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApproveOTPlant");

                entity.Property(e => e.ApproveOtsqen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApproveOTSqen");

                entity.Property(e => e.ApproveOttoken)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ApproveOTToken");
            });

            modelBuilder.Entity<ConfigCheckinTime>(entity =>
            {
                entity.HasKey(e => e.CtAutoId)
                    .HasName("PK__ConfigCh__DE536D7A296C7FD3");

                entity.ToTable("ConfigCheckinTime");

                entity.Property(e => e.CtCreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CtCreateDate).HasColumnType("datetime");

                entity.Property(e => e.CtEditBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CtEditDate).HasColumnType("datetime");

                entity.Property(e => e.CtRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CtStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfigOt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConfigOTs");

                entity.Property(e => e.ConfigOtid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ConfigOTID");

                entity.Property(e => e.ConfigOttime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConfigOTTime");

                entity.Property(e => e.ConfigOttimeActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConfigOTTimeActive");

                entity.Property(e => e.ConfigOttimeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConfigOTTimeType");

                entity.Property(e => e.ConfigOttype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConfigOTType");
            });

            modelBuilder.Entity<EmployeeOt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeOTs");

                entity.Property(e => e.EmployeeDep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEditBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEditDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNamePlant)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePlant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeRemark).HasColumnType("text");

                entity.Property(e => e.EmployeeStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeUserID");

                entity.Property(e => e.EmployeeUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeaderOt>(entity =>
            {
                entity.HasKey(e => e.HeaderQtid)
                    .HasName("PK_HeaderQT");

                entity.ToTable("HeaderOTs");

                entity.Property(e => e.HeaderQtid).HasColumnName("HeaderQTID");

                entity.Property(e => e.HeaderConfirm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderQtcondition).HasColumnName("HeaderQTCondition");

                entity.Property(e => e.HeaderQtcreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTCreateBy");

                entity.Property(e => e.HeaderQtcreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HeaderQTCreateDate");

                entity.Property(e => e.HeaderQtdateEnAffect)
                    .HasColumnType("date")
                    .HasColumnName("HeaderQTDateEnAffect");

                entity.Property(e => e.HeaderQtdateStAffect)
                    .HasColumnType("date")
                    .HasColumnName("HeaderQTDateStAffect");

                entity.Property(e => e.HeaderQtdep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTDep");

                entity.Property(e => e.HeaderQtdetailOt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTDetailOT");

                entity.Property(e => e.HeaderQtdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTDoc");

                entity.Property(e => e.HeaderQteditBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTEditBy");

                entity.Property(e => e.HeaderQteditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HeaderQTEditDate");

                entity.Property(e => e.HeaderQthraffect)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTHRAffect");

                entity.Property(e => e.HeaderQtleaderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTLeaderID");

                entity.Property(e => e.HeaderQtnameYard)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTNameYard");

                entity.Property(e => e.HeaderQtplant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTPlant");

                entity.Property(e => e.HeaderQtremark)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTRemark");

                entity.Property(e => e.HeaderQtremarkApprove)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTRemarkApprove");

                entity.Property(e => e.HeaderQtrevise)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTRevise");

                entity.Property(e => e.HeaderQtreviseHr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTReviseHR");

                entity.Property(e => e.HeaderQtstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTStatus");

                entity.Property(e => e.HeaderQtstatusApprove)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTStatusApprove");

                entity.Property(e => e.HeaderQtstatusTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTStatusTime");

                entity.Property(e => e.HeaderQtsumOt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTSumOT");

                entity.Property(e => e.HeaderQtsumPersons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTSumPersons");

                entity.Property(e => e.HeaderQttimeEnAffect).HasColumnName("HeaderQTTimeEnAffect");

                entity.Property(e => e.HeaderQttimeStAffect).HasColumnName("HeaderQTTimeStAffect");

                entity.Property(e => e.HeaderQttypeApprove)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTTypeApprove");

                entity.Property(e => e.HeaderQtyard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTYard");

                entity.Property(e => e.HeaderTypeOt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HeaderTypeOT");

                entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
            });

            modelBuilder.Entity<ItemOt>(entity =>
            {
                entity.HasKey(e => e.ItemQtid)
                    .HasName("PK_ItemOT");

                entity.ToTable("ItemOTs");

                entity.Property(e => e.ItemQtid).HasColumnName("ItemQTID");

                entity.Property(e => e.BplusDocNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BPlusDocNo");

                entity.Property(e => e.ItemQtcondition).HasColumnName("ItemQTCondition");

                entity.Property(e => e.ItemQtcreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTCreateBy");

                entity.Property(e => e.ItemQtcreateDate)
                    .HasColumnType("date")
                    .HasColumnName("ItemQTCreateDate");

                entity.Property(e => e.ItemQtdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTDoc");

                entity.Property(e => e.ItemQteditBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTEditBy");

                entity.Property(e => e.ItemQteditDate)
                    .HasColumnType("date")
                    .HasColumnName("ItemQTEditDate");

                entity.Property(e => e.ItemQtempId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTEmpId");

                entity.Property(e => e.ItemQtempName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTEmpName");

                entity.Property(e => e.ItemQtremark)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTRemark");

                entity.Property(e => e.ItemQtrevise)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTRevise");

                entity.Property(e => e.ItemQtstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTStatus");

                entity.Property(e => e.ItemQttimeEnAffect).HasColumnName("ItemQTTimeEnAffect");

                entity.Property(e => e.ItemQttimeStAffect).HasColumnName("ItemQTTimeStAffect");

                entity.Property(e => e.ItemQttotalTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemQTTotalTime");

                entity.Property(e => e.ItemRpastatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemRPAStatus");
            });

            modelBuilder.Entity<Otautorun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OTAUTORUN");

                entity.Property(e => e.OtAutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OT_AutoID");

                entity.Property(e => e.OtId).HasColumnName("OT_ID");

                entity.Property(e => e.OtPlant)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OT_Plant");

                entity.Property(e => e.OtType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OT_Type");

                entity.Property(e => e.OtYear)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OT_Year");
            });

            modelBuilder.Entity<ScanFile>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ScanFileAutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ScanFileAutoID");

                entity.Property(e => e.ScanFileDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScanFileDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanFileMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanFilePlant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanFileRevise)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanFileStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.ScanFileYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransectionsCheckin>(entity =>
            {
                entity.HasKey(e => e.TrAutoId)
                    .HasName("PK__Transect__164A1D70E277CC02");

                entity.ToTable("TransectionsCheckin");

                entity.Property(e => e.HeaderQtdoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HeaderQTDoc");

                entity.Property(e => e.TrCreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrCreateDate).HasColumnType("datetime");

                entity.Property(e => e.TrDocImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrEditBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrEditDate).HasColumnType("datetime");

                entity.Property(e => e.TrRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TrStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
