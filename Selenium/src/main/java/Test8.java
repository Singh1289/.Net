import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.support.ui.Select;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test8 {

	public static void main(String[] args) throws InterruptedException {
		WebDriverManager.edgedriver().setup();
		WebDriver driver = new EdgeDriver();
		
		driver.get("https://demo.guru99.com/test/newtours/register.php");
		driver.manage().window().maximize();
		Thread.sleep(2000);
		Select country = new Select(driver.findElement(By.name("country")));
		Thread.sleep(2000);
		
		
		driver.findElement(By.name("firstName")).sendKeys("Rohit");
		Thread.sleep(2000);
		driver.findElement(By.name("lastName")).sendKeys("Ubale");
		Thread.sleep(2000);
		driver.findElement(By.name("phone")).sendKeys("9284918904");
		
		
		country.selectByVisibleText("ANTARCTICA");
		Thread.sleep(2000);
		
		driver.get("https://jsbin.com/osebed/2");
		Thread.sleep(2000);
		
		Select fruits = new Select(driver.findElement(By.id("fruits")));
		Thread.sleep(2000);
		
		fruits.selectByVisibleText("Banana");
		Thread.sleep(2000);
		
		fruits.selectByIndex(2);
		Thread.sleep(2000);
		driver.close();

	}

}
