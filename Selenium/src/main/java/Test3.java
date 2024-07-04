import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.testng.annotations.Test;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test3 {
	@Test
	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		WebDriverManager.edgedriver().setup();
		WebDriver driver = new EdgeDriver();
		
		driver.get("https://demo.guru99.com/test/radio.html");
		
//		driver.findElement(By.name("webform")).click();
		driver.findElement(By.id("vfb-6-0")).click();
		Thread.sleep(1000);
		driver.findElement(By.id("vfb-6-1")).click();
		Thread.sleep(1000);
		driver.findElement(By.id("vfb-6-2")).click();
		Thread.sleep(1000);
		driver.findElement(By.id("vfb-7-1")).click();
		Thread.sleep(1000);
		driver.findElement(By.id("vfb-7-3")).click();
		Thread.sleep(10000);
		driver.close();
	}

}
