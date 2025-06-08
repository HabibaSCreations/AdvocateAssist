namespace AdvocateAssist.Models
{
	public class Role
	{
		public int RoleId { get; set; }
		public string RoleName { get; set; }
		public ICollection<User> Users { get; set; }
		
	}

	public class User
	{
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string PasswordHash { get; set; }
		public  int RoleId { get; set; }
		public virtual Role Role { get; set; }
		public ICollection<Notification> Notifications { get; set; }
		public ICollection<TaskItem> TaskItems { get; set; }
		public ICollection<Appointment> Appointments { get; set; }

	}

	public class Appointment
	{
	}

	public class TaskItem
	{
	}

	public class Notification
	{
	}
}
