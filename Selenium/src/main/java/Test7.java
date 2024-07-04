import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.interactions.Actions;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test7 {


		public static void main(String[] args) throws InterruptedException {
			// TODO Auto-generated method stub
			WebDriverManager.edgedriver().setup();
			WebDriver driver = new EdgeDriver();
			
			driver.get("https://jqueryui.com/resizable/");
			driver.manage().window().maximize();
			
			WebElement frame = driver.findElement(By.xpath("//*[@id=\"content\"]/iframe"));
			driver.switchTo().frame(frame);
			WebElement element =  driver.findElement(By.xpath("//*[@id=\"resizable\"]/Div[3]"));
			Actions action = new Actions(driver);
			Thread.sleep(3000);
			
			action.dragAndDropBy(element,0, 150).perform();

		}
	}



