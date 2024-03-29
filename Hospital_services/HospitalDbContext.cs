using Hospital.entities;
using Hospital_entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital_services
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<PatientOperation> PatientOperations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ActionLog> ActionLogs { get; set; }
        public DbSet<MedicinePrescription> MedicinePrescriptions { get; set; }
        public DbSet<DoctorMedicalRecord> DoctorMedicalRecords { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Patient - Appointment
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.appointments)
                .HasForeignKey(a => a.PatientID)
                .OnDelete(DeleteBehavior.NoAction);

            // Doctor - Appointment
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.appointments)
                .HasForeignKey(a => a.DoctorID)
                .OnDelete(DeleteBehavior.NoAction);

            // Patient - MedicalRecord
            modelBuilder.Entity<MedicalRecord>()
                .HasOne(m => m.Patient)
                .WithMany(p => p.medicalRecords)
                .HasForeignKey(m => m.PatientID)
                .OnDelete(DeleteBehavior.NoAction);

            // Patient - Billing
            modelBuilder.Entity<Billing>()
                .HasOne(b => b.Patient)
                .WithMany(p => p.billing)
                .HasForeignKey(b => b.PatientID)
                .OnDelete(DeleteBehavior.NoAction);

            // Patient - Prescription
            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.Patient)
                .WithMany(p => p.prescriptions)
                .HasForeignKey(p => p.PatientID)
                .OnDelete(DeleteBehavior.NoAction);

            // Doctor - Prescription
            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.Doctor)
                .WithMany(d => d.prescriptions)
                .HasForeignKey(p => p.DoctorID)
                .OnDelete(DeleteBehavior.NoAction);

            // Department - Doctor
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Department)
                .WithMany(dept => dept.doctors)
                .HasForeignKey(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            // Department - Staff
            modelBuilder.Entity<Staff>()
                .HasOne(s => s.Department)
                .WithMany(dept => dept.staff)
                .HasForeignKey(s => s.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserPermissions)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.Permission)
                .WithMany(p => p.UserPermissions)
                .HasForeignKey(up => up.PermissionId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<PatientOperation>()
                .HasOne(p => p.Patient)
                .WithMany(o => o.patient_operations)
                .HasForeignKey(fk => fk.PatientId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<PatientOperation>()
                .HasOne(p => p.Operation)
                .WithMany(o => o.PatientOperations)
                .HasForeignKey(fk => fk.OperationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Medicine>()
                .HasOne(p => p.Category)
                .WithMany(o => o.Medicine)
                .HasForeignKey(fk => fk.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>()
                .HasOne(p => p.Parent)
                .WithMany(p => p.Categories)
                .HasForeignKey(p => p.ParentId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Medicine>()
                .HasOne(m => m.Manufacturer)
                .WithMany(md => md.Medicines)
                .HasForeignKey(fk => fk.ManufacturerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ActionLog>()
                .HasOne(a => a.User)
                .WithMany(u => u.ActionLogs)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MedicinePrescription>()
                .HasOne(p => p.Prescription)
                .WithMany(o => o.medicinePrescriptions)
                .HasForeignKey(fk => fk.PrescriptionId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<MedicinePrescription>()
                .HasOne(p => p.Medicine)
                .WithMany(o => o.medicinePrescriptions)
                .HasForeignKey(fk => fk.MedicineId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
              .HasOne(a => a.User)
              .WithMany(u => u.Appointments)
              .HasForeignKey(a => a.UserId)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DoctorMedicalRecord>()
               .HasOne(p => p.Doctor)
               .WithMany(o => o.doctorMedicalRecord)
               .HasForeignKey(fk => fk.DoctorId)
               .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<DoctorMedicalRecord>()
                .HasOne(p => p.MedicalRecord)
                .WithMany(o => o.DoctorMedicalRecords)
                .HasForeignKey(fk => fk.MedicalRecordId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
