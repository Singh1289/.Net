import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;

import io.github.bonigarcia.wdm.WebDriverManager;


public class test4 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		WebDriverManager.edgedriver().setup();
		WebDriver driver = new EdgeDriver();
		
		driver.get("https://demo.guru99.com/test/radio.html");
		
//		driver.findElement(By.name("webform")).click();
		driver.findElement(By.xpath("/html/body/div[4]/input[5]")).click();
		Thread.sleep(3000);
		driver.findElement(By.xpath("//*[@id=\"vfb-6-1\"]"));
		Thread.sleep(1000);
		driver.findElement(By.id("vfb-6-1")).click();
		Thread.sleep(3000);
		driver.findElement(By.id("vfb-6-2")).click();
		Thread.sleep(3000);
		driver.findElement(By.name("webform")).click();
//		Thread.sleep(1000);
//		driver.findElement(By.id("vfb-7-3")).click();
	}
}
