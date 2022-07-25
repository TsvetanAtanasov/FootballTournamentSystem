pipeline {
  agent any
	stages {
    stage('Docker Build') {
      steps {  
        powershell(script: 'docker-compose build') 
        powershell(script: 'docker images -a')
      }
    }
	stage('Run Test Application') {
      steps {
        powershell(script: 'docker-compose up -d')    
      }
    }
	stage('Stop Test Application') {
      steps {
        powershell(script: 'docker-compose down') 
        // powershell(script: 'docker volumes prune -f')   		
      }
      post {
	    success {
	      echo "Build successfull! You should deploy! :)"
	    }
	    failure {
	      echo "Build failed! You should receive an e-mail! :("
	    }
      }
    }
	stage('Push Images') {
      when { branch 'master' }
      steps {
        script {
          docker.withRegistry('https://index.docker.io/v1/', 'DockerHub') {
            def identityImage = docker.image("tsvetan97/footballtournamentsystem-identity-service")
            identityImage.push("1.0.${env.BUILD_ID}")
            identityImage.push('latest')
			
			def tournamentImage = docker.image("tsvetan97/footballtournamentsystem-tournament-service")
            tournamentImage.push("1.0.${env.BUILD_ID}")
            tournamentImage.push('latest')
			
			def personImage = docker.image("tsvetan97/footballtournamentsystem-person-service")
            personImage.push("1.0.${env.BUILD_ID}")
            personImage.push('latest')
			
			def statisticsImage = docker.image("tsvetan97/footballtournamentsystem-statistics-service")
            statisticsImage.push("1.0.${env.BUILD_ID}")
            statisticsImage.push('latest')
			
			def watchdogImage = docker.image("tsvetan97/footballtournamentsystem-watchdog-service")
            watchdogImage.push("1.0.${env.BUILD_ID}")
            watchdogImage.push('latest')
          }
        }
      }
    }
  }
}