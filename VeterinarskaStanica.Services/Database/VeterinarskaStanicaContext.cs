using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VeterinarskaStanica.Services.Database;

public partial class VeterinarskaStanicaContext : DbContext
{
    public VeterinarskaStanicaContext()
    {
    }

    public VeterinarskaStanicaContext(DbContextOptions<VeterinarskaStanicaContext> options)
        : base(options)
    {
    }


    public virtual DbSet<JediniceMjere> JediniceMjeres { get; set; }

    public virtual DbSet<Korisnici> Korisnicis { get; set; }

    public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }

    public virtual DbSet<Kupci> Kupcis { get; set; }

    public virtual DbSet<NarudzbaStavke> NarudzbaStavkes { get; set; }

    public virtual DbSet<Narudzbe> Narudzbes { get; set; }

    public virtual DbSet<Proizvodi> Proizvodis { get; set; }


    public virtual DbSet<Uloge> Uloges { get; set; }

	public virtual DbSet<Usluge> Usluges { get; set; }
	public virtual DbSet<VrsteProizvodum> VrsteProizvoda { get; set; }

	public virtual DbSet<VrsteUsluga> VrsteUslugas { get; set; }

	public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }

	public virtual DbSet<RadnaMjesta> RadnaMjesta { get; set; }

	//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
	//        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=test123; user=sa; password=QWEasd123!; TrustServerCertificate=true");

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=VeterinarskaStanica; user=sa; password=QWEasd123!; TrustServerCertificate=true");
		}
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<JediniceMjere>(entity =>
        {
            entity.HasKey(e => e.JedinicaMjereId);

            entity.ToTable("JediniceMjere");

            entity.Property(e => e.JedinicaMjereId).HasColumnName("JedinicaMjereID");
            entity.Property(e => e.Naziv).HasMaxLength(10);
        });

        modelBuilder.Entity<Korisnici>(entity =>
        {
            entity.HasKey(e => e.KorisnikId);

            entity.ToTable("Korisnici");

            entity.HasIndex(e => e.Email, "CS_Email").IsUnique();

            entity.HasIndex(e => e.KorisnickoIme, "CS_KorisnickoIme").IsUnique();

            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Ime).HasMaxLength(50);
            entity.Property(e => e.KorisnickoIme).HasMaxLength(50);
            entity.Property(e => e.LozinkaHash).HasMaxLength(50);
            entity.Property(e => e.LozinkaSalt).HasMaxLength(50);
            entity.Property(e => e.Prezime).HasMaxLength(50);
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<KorisniciUloge>(entity =>
        {
            entity.HasKey(e => e.KorisnikUlogaId);

            entity.ToTable("KorisniciUloge");

            entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");
            entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");
            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");
            entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KorisniciUloges)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KorisniciUloge_Korisnici");

            entity.HasOne(d => d.Uloga).WithMany(p => p.KorisniciUloges)
                .HasForeignKey(d => d.UlogaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KorisniciUloge_Uloge");
        });

        modelBuilder.Entity<Kupci>(entity =>
        {
            entity.HasKey(e => e.KupacId);

            entity.ToTable("Kupci");

            entity.Property(e => e.KupacId).HasColumnName("KupacID");
            entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Ime).HasMaxLength(50);
            entity.Property(e => e.KorisnickoIme).HasMaxLength(50);
            entity.Property(e => e.LozinkaHash).HasMaxLength(50);
            entity.Property(e => e.LozinkaSalt).HasMaxLength(50);
            entity.Property(e => e.Prezime).HasMaxLength(50);
        });

        modelBuilder.Entity<NarudzbaStavke>(entity =>
        {
            entity.HasKey(e => e.NarudzbaStavkaId);

            entity.ToTable("NarudzbaStavke");

            entity.Property(e => e.NarudzbaStavkaId).HasColumnName("NarudzbaStavkaID");
            entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");
            entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

            entity.HasOne(d => d.Narudzba).WithMany(p => p.NarudzbaStavkes)
                .HasForeignKey(d => d.NarudzbaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NarudzbaStavke_Narudzbe");

            entity.HasOne(d => d.Proizvod).WithMany(p => p.NarudzbaStavkes)
                .HasForeignKey(d => d.ProizvodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NarudzbaStavke_Proizvodi");
        });

        modelBuilder.Entity<Narudzbe>(entity =>
        {
            entity.HasKey(e => e.NarudzbaId);

            entity.ToTable("Narudzbe");

            entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");
            entity.Property(e => e.BrojNarudzbe).HasMaxLength(20);
            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.KupacId).HasColumnName("KupacID");

            entity.HasOne(d => d.Kupac).WithMany(p => p.Narudzbes)
                .HasForeignKey(d => d.KupacId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Narudzbe_Kupci");
        });

        modelBuilder.Entity<Proizvodi>(entity =>
        {
            entity.HasKey(e => e.ProizvodId);

            entity.ToTable("Proizvodi");

            entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");
            entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JedinicaMjereId).HasColumnName("JedinicaMjereID");
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

            entity.HasOne(d => d.JedinicaMjere).WithMany(p => p.Proizvodis)
                .HasForeignKey(d => d.JedinicaMjereId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proizvodi_JediniceMjere");

            entity.HasOne(d => d.Vrsta).WithMany(p => p.Proizvodis)
                .HasForeignKey(d => d.VrstaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proizvodi_VrsteProizvoda");
        });


        modelBuilder.Entity<Uloge>(entity =>
        {
            entity.HasKey(e => e.UlogaId);

            entity.ToTable("Uloge");

            entity.Property(e => e.UlogaId).HasColumnName("UlogaID");
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.Opis).HasMaxLength(200);
        });

		modelBuilder.Entity<Usluge>(entity =>
		{
			entity.HasKey(e => e.UslugaId);

			entity.ToTable("Usluge");

			entity.Property(e => e.UslugaId).HasColumnName("UslugaID");
			entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");
			entity.Property(e => e.JedinicaMjereId).HasColumnName("JedinicaMjereID");
			entity.Property(e => e.Naziv).HasMaxLength(50);
			entity.Property(e => e.Sifra).HasMaxLength(20);
			entity.Property(e => e.Status)
				.IsRequired()
				.HasDefaultValueSql("((1))");
			entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

			entity.HasOne(d => d.JedinicaMjere).WithMany(p => p.Usluges)
				.HasForeignKey(d => d.JedinicaMjereId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Usluge_JediniceMjere");

			entity.HasOne(d => d.Usluga).WithMany(p => p.Usluges)
						   .HasForeignKey(d => d.VrstaId)
						   .OnDelete(DeleteBehavior.ClientSetNull)
						   .HasConstraintName("FK_Usluge_VrsteUsluga");
		});

		modelBuilder.Entity<VrsteProizvodum>(entity =>
        {
            entity.HasKey(e => e.VrstaId);

            entity.Property(e => e.VrstaId).HasColumnName("VrstaID");
            entity.Property(e => e.Naziv).HasMaxLength(50);
        });

		modelBuilder.Entity<VrsteUsluga>(entity =>
		{
			entity.HasKey(e => e.VrstaId);

			entity.Property(e => e.VrstaId).HasColumnName("VrstaID");
			entity.Property(e => e.Naziv).HasMaxLength(50);
		});

		modelBuilder.Entity<Zaposlenici>(entity =>
		{
			entity.HasKey(e => e.ZaposlenikID);

			entity.Property(e => e.ZaposlenikID).HasColumnName("ZaposlenikID");
			entity.Property(e => e.Ime).HasMaxLength(50);
			entity.Property(e => e.Prezime).HasMaxLength(50);
			entity.Property(e => e.RadnoMjestoId).HasColumnName("RadnoMjestoID");
			entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");
			entity.Property(e => e.Plata).HasColumnType("decimal(18, 2)");

			entity.HasOne(d => d.RadnaMjesta).WithMany(p => p.Zaposlenicis)
			   .HasForeignKey(d => d.RadnoMjestoId)
			   .OnDelete(DeleteBehavior.ClientSetNull)
			   .HasConstraintName("FK_Zaposlenici_RadnaMjesta");
		});

		modelBuilder.Entity<RadnaMjesta>(entity =>
		{
			entity.HasKey(e => e.RadnaMjestaId);

			entity.ToTable("RadnaMjesta");

			entity.Property(e => e.RadnaMjestaId).HasColumnName("RadnaMjestaID");
			entity.Property(e => e.Naziv).HasMaxLength(50);
		});

		OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
