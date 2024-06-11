package pl.opole.uni.springBootJSF.service;
import java.util.List;
import org.ocpsoft.rewrite.el.ELBeanName;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Component;
import pl.opole.uni.springBootJSF.model.Game;
import pl.opole.uni.springBootJSF.model.GameRepository;

@Scope(value = "session")
@Component(value = "GameController")
@ELBeanName(value = "GameController")
public class GameController {

    @Autowired
    private GameRepository gameRepository;
    private List<Game> games;
    public GameRepository getGameRepository() {
		return gameRepository;
	}
	public void setGameRepository(GameRepository gameRepository) {
		this.gameRepository = gameRepository;
	}
	public List<Game> getGames() {
		return games;
	}
	public void setGames(List<Game> games) {
		this.games = games;
	}
	public Game getSelectedGame() {
		return selectedGame;
	}
	public void setSelectedGame(Game selectedGame) {
		this.selectedGame = selectedGame;
	}
	private Game selectedGame;
    
  
    
    }
