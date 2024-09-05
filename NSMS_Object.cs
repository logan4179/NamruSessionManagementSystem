using UnityEngine;


namespace NamruSessionManagementSystem
{
	/// <summary>
	/// Base classes with in-built Log functions. Can be extended if needed.
	/// </summary>
	public class NSMS_Object : MonoBehaviour
	{
		protected void Log(string message, LogDestination destination = LogDestination.Hidden, NAMRU_LogType format = NAMRU_LogType.None)
		{
			string formattedMessage = string.Empty;

			if (format == NAMRU_LogType.None)
			{
				formattedMessage = $"[{gameObject.name}.{name}] >> {message}";
			}
			else if (format == NAMRU_LogType.UserMethod)
			{
				formattedMessage = $"[{gameObject.name}.{name}] >> {message}";
			}
			else if (format == NAMRU_LogType.UnityAPI)
			{
				formattedMessage = $"[{gameObject.name}.{name}] >> {message}";
			}

			NamruLogManager.Log(formattedMessage, destination);
		}

		protected void LogInc(string message, LogDestination destination = LogDestination.Hidden, NAMRU_LogType format = NAMRU_LogType.None)
		{
			Log(message, destination, format);

			NamruLogManager.IncrementTabLevel();
		}

		protected void LogWarning(string message)
		{
			NamruLogManager.LogWarning($"[{gameObject.name}.{name}] >> {message}");
		}

		protected void LogError(string message)
		{
			NamruLogManager.LogError($"[{gameObject.name}.{name}] >> {message}");
		}
	}
}