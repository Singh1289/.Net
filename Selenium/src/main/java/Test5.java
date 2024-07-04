import org.openqa.selenium.Alert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test5 {


		public static void main(String[] args) throws InterruptedException {
			// TODO Auto-generated method stub
			WebDriverManager.edgedriver().setup();
			WebDriver driver = new EdgeDriver();
			
			driver.get("https://demo.guru99.com/test/delete_customer.php");
			// full x path /html/body/form/table/tbody/tr[2]/td[2]/input
			// x path /html/body/form/table/tbody/tr[2]/td[2]/input
		driver.findElement(By.xpath("/html/body/form/table/tbody/tr[2]/td[2]/input")).sendKeys("45");
		driver.findElement(By.name("submit")).click();
		
		// change focus to alert
		
		Alert alert = driver.switchTo().alert();
		
		// getting alert msg
		
		String alertMsg =driver.switchTo().alert().getText();
		
		//displaying the msg
		System.out.println(alertMsg);
		
		alert.accept();
		Thread.sleep(2000);
		//alert.dismiss();
		
		Alert alert1 = driver.switchTo().alert();
		Thread.sleep(2000);
		alert1.accept();

		}
	}


