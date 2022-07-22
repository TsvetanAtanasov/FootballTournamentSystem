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
  }
}