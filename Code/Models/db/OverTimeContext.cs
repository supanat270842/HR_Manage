using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Models.db;

public partial class OverTimeContext : DbContext
{
    public OverTimeContext()
    {
    }

    public OverTimeContext(DbContextOptions<OverTimeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apidetail> Apidetails { get; set; }

    public virtual DbSet<ApproveBplu> ApproveBplus { get; set; }

    public virtual DbSet<ApproveBplusLogin> ApproveBplusLogins { get; set; }

    public virtual DbSet<ApproveOt> ApproveOts { get; set; }

    public virtual DbSet<BplusOttype> BplusOttypes { get; set; }

    public virtual DbSet<ConditionApproveBplu> ConditionApproveBplus { get; set; }

    public virtual DbSet<ConfigCheckinTime> ConfigCheckinTimes { get; set; }

    public virtual DbSet<ConfigOt> ConfigOts { get; set; }

    public virtual DbSet<EmployeeOt> EmployeeOts { get; set; }

    public virtual DbSet<HeaderOt> HeaderOts { get; set; }

    public virtual DbSet<IsNull> IsNulls { get; set; }

    public virtual DbSet<ItemOt> ItemOts { get; set; }

    public virtual DbSet<Memployee> Memployees { get; set; }

    public virtual DbSet<Otautorun> Otautoruns { get; set; }

    public virtual DbSet<Ottype> Ottypes { get; set; }

    public virtual DbSet<Recoder> Recoders { get; set; }

    public virtual DbSet<RecoderBplusLogin> RecoderBplusLogins { get; set; }

    public virtual DbSet<RecoderNew> RecoderNews { get; set; }

    public virtual DbSet<RemarkCdtOttype> RemarkCdtOttypes { get; set; }

    public virtual DbSet<RpaOt> RpaOts { get; set; }

    public virtual DbSet<RpaOtspare> RpaOtspares { get; set; }

    public virtual DbSet<RpacreateBplu> RpacreateBplus { get; set; }

    public virtual DbSet<Rpadetail> Rpadetails { get; set; }

    public virtual DbSet<Rpaexcel> Rpaexcels { get; set; }

    public virtual DbSet<ScanFile> ScanFiles { get; set; }

    public virtual DbSet<SpecialCondition> SpecialConditions { get; set; }

    public virtual DbSet<TransectionsCheckin> TransectionsCheckins { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<ViewOverTime> ViewOverTimes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.99;Database=OverTime;User Id=sa;Password=dogthaiP@ssw0rd;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CS_AS_KS_WS");

        modelBuilder.Entity<Apidetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("APIDetail");

            entity.Property(e => e.BotRemark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOT_Remark");
            entity.Property(e => e.HeaderQtdateStAffect)
                .HasColumnType("date")
                .HasColumnName("HeaderQTDateStAffect");
            entity.Property(e => e.HeaderQtdetailOt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HeaderQTDetailOT");
            entity.Property(e => e.HeaderQtdoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTDoc");
            entity.Property(e => e.HeaderTypeOt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HeaderTypeOT");
            entity.Property(e => e.ItemQtempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpId");
            entity.Property(e => e.ItemQtempName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpName");
            entity.Property(e => e.ItemQttimeEnAffect).HasColumnName("ItemQTTimeEnAffect");
            entity.Property(e => e.ItemQttimeStAffect).HasColumnName("ItemQTTimeStAffect");
            entity.Property(e => e.ItemQttotalTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTTotalTime");
        });

        modelBuilder.Entity<ApproveBplu>(entity =>
        {
            entity.HasKey(e => e.ApbautoId).HasName("PK__ApproveB__070EAD7ECFE7166A");

            entity.ToTable("ApproveBPlus");

            entity.Property(e => e.ApbautoId).HasColumnName("APBAutoId");
            entity.Property(e => e.ApbeditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APBEditBy");
            entity.Property(e => e.ApbeditDate)
                .HasColumnType("date")
                .HasColumnName("APBEditDate");
            entity.Property(e => e.ApbfacId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APBFacId");
            entity.Property(e => e.Apbremark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APBRemark");
            entity.Property(e => e.ApbsequenceApprove).HasColumnName("APBSequenceApprove");
            entity.Property(e => e.Apbstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APBStatus");
            entity.Property(e => e.ApbtypeId).HasColumnName("APBTypeId");
            entity.Property(e => e.MdepId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MDepId");
            entity.Property(e => e.MdepName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MDepName");
            entity.Property(e => e.MempId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MEmpId");
            entity.Property(e => e.MempName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEmpName");
        });

        modelBuilder.Entity<ApproveBplusLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ApproveBPlusLogin");

            entity.Property(e => e.ApbfacId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APBFacId");
            entity.Property(e => e.ApbsequenceApprove).HasColumnName("APBSequenceApprove");
            entity.Property(e => e.ApbtypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APBTypeId");
            entity.Property(e => e.EmpKey).HasColumnName("EMP_KEY");
            entity.Property(e => e.MdepId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MDepId");
            entity.Property(e => e.MdepName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MDepName");
            entity.Property(e => e.MempId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MEmpId");
            entity.Property(e => e.MempName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEmpName");
        });

        modelBuilder.Entity<ApproveOt>(entity =>
        {
            entity.HasKey(e => e.ApproveOtid).HasName("PK_ApproveOT");

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

        modelBuilder.Entity<BplusOttype>(entity =>
        {
            entity.HasKey(e => e.BotAutoId).HasName("PK__BPlusOTT__4BB777A066BE2436");

            entity.ToTable("BPlusOTType");

            entity.Property(e => e.BotAutoId).HasColumnName("BOT_AutoId");
            entity.Property(e => e.BotEditBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOT_EditBy");
            entity.Property(e => e.BotEditDate)
                .HasColumnType("date")
                .HasColumnName("BOT_EditDate");
            entity.Property(e => e.BotName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOT_Name");
            entity.Property(e => e.BotRemark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOT_Remark");
            entity.Property(e => e.BotStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOT_Status");
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
        });

        modelBuilder.Entity<ConditionApproveBplu>(entity =>
        {
            entity.HasKey(e => e.CabAutoId).HasName("PK__Conditio__31F645628E819FE6");

            entity.ToTable("ConditionApproveBPlus");

            entity.Property(e => e.CabAutoId).HasColumnName("CAB_AutoId");
            entity.Property(e => e.BotAutoId).HasColumnName("BOT_AutoId");
            entity.Property(e => e.BotName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOT_Name");
            entity.Property(e => e.CabEditBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAB_EditBy");
            entity.Property(e => e.CabEditDate)
                .HasColumnType("date")
                .HasColumnName("CAB_EditDate");
            entity.Property(e => e.CabRemark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAB_Remark");
            entity.Property(e => e.CabStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAB_Status");
            entity.Property(e => e.CabTimeEnd).HasColumnName("CAB_TimeEnd");
            entity.Property(e => e.CabTimeStart).HasColumnName("CAB_TimeStart");
        });

        modelBuilder.Entity<ConfigCheckinTime>(entity =>
        {
            entity.HasKey(e => e.CtAutoId).HasName("PK__ConfigCh__DE536D7A1EE698C4");

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
            entity
                .HasNoKey()
                .ToTable("ConfigOTs");

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
            entity
                .HasNoKey()
                .ToTable("EmployeeOTs");

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
            entity.HasKey(e => e.HeaderQtid).HasName("PK_HeaderQT");

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
            entity.Property(e => e.OttAutoId).HasColumnName("OttAutoID");
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
        });

        modelBuilder.Entity<IsNull>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IS NUll");

            entity.Property(e => e.ItemQtempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpId");
            entity.Property(e => e.ItemQtempName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpName");
            entity.Property(e => e.RempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REmpID");
        });

        modelBuilder.Entity<ItemOt>(entity =>
        {
            entity.HasKey(e => e.ItemQtid).HasName("PK_ItemOT");

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
            entity.Property(e => e.SaveBplusDone).HasColumnName("SaveBPlusDone");
        });

        modelBuilder.Entity<Memployee>(entity =>
        {
            entity.HasKey(e => e.MempAutoId).HasName("PK__MEmploye__80BC917CAA37D9EB");

            entity.ToTable("MEmployee");

            entity.Property(e => e.MempAutoId).HasColumnName("MEmpAutoId");
            entity.Property(e => e.EmpKey).HasColumnName("EMP_KEY");
            entity.Property(e => e.MadminFac)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAdminFac");
            entity.Property(e => e.MdepId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MDepId");
            entity.Property(e => e.MempEditDate)
                .HasColumnType("date")
                .HasColumnName("MEmpEditDate");
            entity.Property(e => e.MempId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MEmpId");
            entity.Property(e => e.MempName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEmpName");
            entity.Property(e => e.MempRemark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MEmpRemark");
            entity.Property(e => e.MempStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Otautorun>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTAUTORUN");

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

        modelBuilder.Entity<Ottype>(entity =>
        {
            entity.HasKey(e => e.OttAutoId).HasName("PK__OTType__74612DB096A2A0DF");

            entity.ToTable("OTType");

            entity.Property(e => e.OttAutoId).HasColumnName("OttAutoID");
            entity.Property(e => e.OttCreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OttCreateDate).HasColumnType("date");
            entity.Property(e => e.OttEditBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OttEditDate).HasColumnType("date");
            entity.Property(e => e.OttName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OttStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Recoder>(entity =>
        {
            entity.HasKey(e => e.RautoId).HasName("PK__Recoder__F36D9178554DA4E4");

            entity.ToTable("Recoder");

            entity.Property(e => e.RautoId).HasColumnName("RAutoID");
            entity.Property(e => e.RdepId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RDepID");
            entity.Property(e => e.RdepName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RDepName");
            entity.Property(e => e.RecodeEmpName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RecoderEmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RecoderEmpID");
            entity.Property(e => e.ReditBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REditBy");
            entity.Property(e => e.ReditDate)
                .HasColumnType("date")
                .HasColumnName("REditDate");
            entity.Property(e => e.RempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REmpID");
            entity.Property(e => e.RempName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REmpName");
            entity.Property(e => e.Rstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RStatus");
        });

        modelBuilder.Entity<RecoderBplusLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RecoderBPlusLogin");

            entity.Property(e => e.EmpKey).HasColumnName("EMP_KEY");
            entity.Property(e => e.RecodeEmpName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RecoderEmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RecoderEmpID");
            entity.Property(e => e.RempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REmpID");
            entity.Property(e => e.RempName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REmpName");
        });

        modelBuilder.Entity<RecoderNew>(entity =>
        {
            entity.HasKey(e => e.RnautoId).HasName("PK__RecoderN__70127E0CA90A369E");

            entity.ToTable("RecoderNew");

            entity.Property(e => e.RnautoId).HasColumnName("RNAutoID");
            entity.Property(e => e.RecoderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RncreateBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RNCreateBy");
            entity.Property(e => e.RncreateDate)
                .HasColumnType("date")
                .HasColumnName("RNCreateDate");
            entity.Property(e => e.RneditBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RNEditBy");
            entity.Property(e => e.RneditDate)
                .HasColumnType("date")
                .HasColumnName("RNEditDate");
            entity.Property(e => e.Rnfactory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RNFactory");
            entity.Property(e => e.Rnpassword)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RNPassword");
            entity.Property(e => e.Rnstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RNStatus");
            entity.Property(e => e.RnuserName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RNUserName");
        });

        modelBuilder.Entity<RemarkCdtOttype>(entity =>
        {
            entity.HasKey(e => e.RmautoId).HasName("PK__RemarkCd__65F82C082A4679D7");

            entity.ToTable("RemarkCdtOTType");

            entity.Property(e => e.RmautoId).HasColumnName("RMAutoID");
            entity.Property(e => e.RmheaderQtdoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RMHeaderQTDoc");
            entity.Property(e => e.Rmremark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RMRemark");
        });

        modelBuilder.Entity<RpaOt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPA_OT");

            entity.Property(e => e.BplusDocNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BPlusDocNo");
            entity.Property(e => e.EmpKey).HasColumnName("EMP_KEY");
            entity.Property(e => e.HeaderConfirm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeaderQtcondition).HasColumnName("HeaderQTCondition");
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
            entity.Property(e => e.HeaderQtplant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTPlant");
            entity.Property(e => e.HeaderQtremark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("HeaderQTRemark");
            entity.Property(e => e.HeaderTypeOt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HeaderTypeOT");
            entity.Property(e => e.ItemQtcondition).HasColumnName("ItemQTCondition");
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
            entity.Property(e => e.SaveBplusDone).HasColumnName("SaveBPlusDone");
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
        });

        modelBuilder.Entity<RpaOtspare>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPA_OTSpare");

            entity.Property(e => e.BplusDocNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BPlusDocNo");
            entity.Property(e => e.EmpKey).HasColumnName("EMP_KEY");
            entity.Property(e => e.HeaderConfirm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeaderQtcondition).HasColumnName("HeaderQTCondition");
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
            entity.Property(e => e.HeaderQtplant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTPlant");
            entity.Property(e => e.HeaderQtremark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("HeaderQTRemark");
            entity.Property(e => e.HeaderQtstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTStatus");
            entity.Property(e => e.HeaderQtstatusApprove)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTStatusApprove");
            entity.Property(e => e.HeaderTypeOt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HeaderTypeOT");
            entity.Property(e => e.ItemQtcondition).HasColumnName("ItemQTCondition");
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
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
        });

        modelBuilder.Entity<RpacreateBplu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPACreateBplus");

            entity.Property(e => e.BplusDocNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BPlusDocNo");
            entity.Property(e => e.EmpKey).HasColumnName("EMP_KEY");
            entity.Property(e => e.HeaderConfirm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeaderQtcondition).HasColumnName("HeaderQTCondition");
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
            entity.Property(e => e.HeaderQtplant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTPlant");
            entity.Property(e => e.HeaderQtremark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("HeaderQTRemark");
            entity.Property(e => e.HeaderTypeOt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HeaderTypeOT");
            entity.Property(e => e.ItemQtcondition).HasColumnName("ItemQTCondition");
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
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
        });

        modelBuilder.Entity<Rpadetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPADetail");

            entity.Property(e => e.Ot)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OT");
            entity.Property(e => e.ชอ)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ชื่อ");
            entity.Property(e => e.ประเภทOt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ประเภท OT");
            entity.Property(e => e.รหสพนกงาน)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("รหัสพนักงาน");
            entity.Property(e => e.วนททำOt)
                .HasColumnType("date")
                .HasColumnName("วันที่ทำ OT");
            entity.Property(e => e.หมายเหต)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("หมายเหตุ");
            entity.Property(e => e.เลขทเอกสาร)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("เลขที่เอกสาร");
            entity.Property(e => e.เวลารวม)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.เวลาสนสด).HasColumnName("เวลาสิ้นสุด");
            entity.Property(e => e.เวลาเรมตน).HasColumnName("เวลาเริ่มต้น");
        });

        modelBuilder.Entity<Rpaexcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RPAExcel");

            entity.Property(e => e.BotRemark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOT_Remark");
            entity.Property(e => e.HeaderQtdateStAffect)
                .HasColumnType("date")
                .HasColumnName("HeaderQTDateStAffect");
            entity.Property(e => e.ItemQtempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpId");
            entity.Property(e => e.ItemQtempName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpName");
            entity.Property(e => e.ItemQttotalTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTTotalTime");
        });

        modelBuilder.Entity<ScanFile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ScanFileAutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ScanFileAutoID");
            entity.Property(e => e.ScanFileDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
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

        modelBuilder.Entity<SpecialCondition>(entity =>
        {
            entity.HasKey(e => e.ScautoId).HasName("PK__SpecialC__0F9C995BC0DF1332");

            entity.ToTable("SpecialCondition");

            entity.Property(e => e.ScautoId).HasColumnName("SCAutoId");
            entity.Property(e => e.ApbtypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APBTypeId");
            entity.Property(e => e.MdepId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MDepId");
            entity.Property(e => e.MempId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MEmpId");
            entity.Property(e => e.MempName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MEmpName");
            entity.Property(e => e.SceditBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCEditBy");
            entity.Property(e => e.SceditDate)
                .HasColumnType("date")
                .HasColumnName("SCEditDate");
            entity.Property(e => e.Scremark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SCRemark");
            entity.Property(e => e.Scstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SCStatus");
        });

        modelBuilder.Entity<TransectionsCheckin>(entity =>
        {
            entity.HasKey(e => e.TrAutoId).HasName("PK__Transect__164A1D704050CB2F");

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

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.HeaderQtdateStAffect)
                .HasColumnType("date")
                .HasColumnName("HeaderQTDateStAffect");
            entity.Property(e => e.ItemQtempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpId");
            entity.Property(e => e.ItemQtempName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpName");
            entity.Property(e => e.ItemQttotalTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTTotalTime");
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.HeaderQtdateStAffect)
                .HasColumnType("date")
                .HasColumnName("HeaderQTDateStAffect");
            entity.Property(e => e.ItemQtempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpId");
            entity.Property(e => e.ItemQtempName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpName");
            entity.Property(e => e.ItemQttotalTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTTotalTime");
            entity.Property(e => e.SttKey).HasColumnName("STT_KEY");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
        });

        modelBuilder.Entity<ViewOverTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewOverTime");

            entity.Property(e => e.HeaderQtdateStAffect)
                .HasColumnType("date")
                .HasColumnName("HeaderQTDateStAffect");
            entity.Property(e => e.HeaderQtdep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTDep");
            entity.Property(e => e.HeaderQtdoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTDoc");
            entity.Property(e => e.HeaderQtplant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTPlant");
            entity.Property(e => e.HeaderQtrevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HeaderQTRevise");
            entity.Property(e => e.HeaderQtstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTStatus");
            entity.Property(e => e.HeaderQtyard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HeaderQTYard");
            entity.Property(e => e.ItemQtempId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpId");
            entity.Property(e => e.ItemQtempName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ItemQTEmpName");
            entity.Property(e => e.ItemQttimeEnAffect).HasColumnName("ItemQTTimeEnAffect");
            entity.Property(e => e.ItemQttimeStAffect).HasColumnName("ItemQTTimeStAffect");
            entity.Property(e => e.ItemQttotalTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemQTTotalTime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
