import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.interactions.Actions;

import io.github.bonigarcia.wdm.WebDriverManager;

public class Test9 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		WebDriverManager.edgedriver().setup();
		WebDriver driver = new EdgeDriver();
		
		driver.get("https://jqueryui.com/slider/#colorpicker");
	
		driver.manage().window().maximize();
		Thread.sleep(2000);
		WebElement frame = driver.findElement(By.xpath("//*[@id=\"content\"]/iframe"));
		driver.switchTo().frame(frame);
		
		WebElement slider = driver.findElement(By.xpath("//*[@id=\"red\"]/span"));
		Actions ac = new Actions(driver);
		
		ac.dragAndDropBy(slider, -20, 50).perform();
		Thread.sleep(3000);
		
		WebElement slider1 = driver.findElement(By.xpath("//*[@id=\"green\"]/span"));
		Actions ac1 = new Actions(driver);
		
		ac1.dragAndDropBy(slider1, -100, 0).perform();
		Thread.sleep(3000);
		
		WebElement slider2 = driver.findElement(By.xpath("//*[@id=\"blue\"]/span"));
		Actions ac2 = new Actions(driver);
		
		ac2.dragAndDropBy(slider2, 110, 50).perform();
		Thread.sleep(3000);
		
		driver.close();
		//driver.quit();
	}

}
