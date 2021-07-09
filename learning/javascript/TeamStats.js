const team = {
    _players:[
      {
        firstName: 'Cristiano',
        lastName: 'Ronaldo',
        age: 36
      },
      {
        firstName: 'Lionel',
        lastName: 'Messi',
        age:32
      },
      {
        firstName: 'Ice',
        lastName: 'Shi',
        ange:37
      }
    ],
    _games:[
      {
        opponent: 'Manchester United',
        teamPoint: 1,
        opponentPoints: 3
      },
      {
        opponent: 'Real Marid',
        teamPoint: 3,
        opponentPoints: 0
      },
      {
        opponent: 'AC Milan',
        teamPoint: 3,
        opponentPoints: 3
      }
    ],
    get players(){
      return this._players;
    },
    get games(){
      return this._games;
    },
    addPlayer(firstName, lastName, age){
      const player = {
        firstName:firstName,
        lastName: lastName,
        age: age
      };
      this._players.push(player);
    },
    addGame(opponent, teamPoint, opponentPoint){
      const game = {
        opponent:opponent,
        teamPoint: teamPoint,
        opponentPoint: opponentPoint
      };
      this._games.push(game);
    }
  };
  
  team.addPlayer('Steph', 'Curry', 28);
  team.addPlayer('Lisa', 'Leslie', 44);
  team.addPlayer('Bugs', 'Bunny', 76);
  
  console.log(team.players);
  
  team.addGame('Team We', 4, 1);
  console.log(team.games);