List 5 essential Git commands with short examples:(more than 5)
1-"git init": creates a new repository
2-"git add": adds files to staging area, e.g git add . (adds all files to staging area)
3-"git commit -m "Commit Message": commits to the changes in files and displays a messsage to each commit
4-"git branch new-breanch-name": creates a new branch, e.g. git branch feature
5-"git checkout branch-name" or "git swtich branch-name": switches between branches, e.g. git checkout feature
6-"git merge brnch-name": merges branches together, e.g. git merge feature (while standing in master branch)
7-"git fetch": downloads changes from remote repository to local repository without merging
8-"git pull": combines "git fetch" and "git merge" to create a pull request and initiate code review
9-"git clone":  downloads a code to your PC
10-"Git push":uploads your work to local repository
11-"touch file-name": lists all created files, e.g. touch index.html
12-"ls -a": makes git list all existing files
13-"git status": lists all files in the staging area
14-"git log --all --graph": shows history of all commits including a graph of branches 
15-"git checkout hash-number": goes back to a certain commit with its specified hash number and undo all what's after it, e.g. git checkout 60a6a20f57e5a313a2e63ca1f66e6b23f7f998


Describe how to:
-Create a branch:
on Git CLI: git branch branch-name (while being on the branch you want to branch it from)
on Github GUI: merge pull request -> confitm merge (in case of merging after creating a pull request (PR))
-Open a Pull Request:
on Git CLI: git pull repo-name(usually origin) branch-name
on the Github GUI: pull requests -> new pull request -> "choose which branch to be compared with master from dropdown menu" -> create pull request
-Resolve a merge conflict: (briefly)
on Git CLI: resolved manually by deleting the lines of code we don't want and keeping the ones we want, or replacing all with new lines
on Github GUI: web editor -> "resolve manually like in git" -> mark as resolved -> commit merge -> merge pull request -> confirm merge
