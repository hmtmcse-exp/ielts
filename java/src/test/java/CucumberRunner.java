import cucumber.api.CucumberOptions;
import cucumber.api.junit.Cucumber;
import org.junit.runner.RunWith;

/**
 * Created by touhid on 29/05/2016.
 */


@RunWith(Cucumber.class)
@CucumberOptions(format={"pretty","html:reports/test-report"},tags= "@translate")
public class CucumberRunner {

}