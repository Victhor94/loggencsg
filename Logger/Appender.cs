﻿/**
 * 
 */
 
namespace Logger {
	public abstract class Appender {

		protected Appender() {
		}

		protected abstract void DoAppend(LogEvent logEvent); 

		public void Append(LogEvent logEvent) {
			DoAppend(logEvent);
		}
	}
}
