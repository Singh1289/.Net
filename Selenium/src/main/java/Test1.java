import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test1 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		WebDriverManager.edgedriver().setup();
		WebDriver driver = new EdgeDriver();
	//	Thread.sleep(3000);
	//	System.setProperty("webdriver.chrome.drive","C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
		
		driver.get("https://www.google.com");
	}

}
