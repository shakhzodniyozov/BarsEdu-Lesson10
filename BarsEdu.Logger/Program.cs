LocalFileLogger<int> logger1 = new("/home/shakhzod/Desktop/logs");
LocalFileLogger<string> logger2 = new("/home/shakhzod/Desktop/logs");
LocalFileLogger<Program> logger3 = new("/home/shakhzod/Desktop/logs");

logger1.LogError("Error from int", new StackOverflowException());
logger2.LogInfo("Info from string");
logger3.LogWarning("Warning from Program");
