import org.openqa.selenium.Alert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.interactions.Actions;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test6 {


		public static void main(String[] args) throws InterruptedException {
			// TODO Auto-generated method stub
			WebDriverManager.edgedriver().setup();
			WebDriver driver = new EdgeDriver();
			
			driver.get("https://jqueryui.com/droppable/");
			driver.manage().window().maximize();
			
			WebElement frame = driver.findElement(By.xpath("//*[@id=\"content\"]/iframe"));
			driver.switchTo().frame(frame);
			WebElement drag = driver.findElement(By.id("draggable"));
			WebElement drop = driver.findElement(By.id("droppable"));
			Actions action = new Actions(driver);
			Thread.sleep(6000);
			action.dragAndDrop(drag, drop).perform();

		}
	}


