
#!/bin/bash

# Check if there are any changes to commit
if [[ -n $(git status -s) ]]; then
    # Stage all changes
    git add .
    
    # Commit with a timestamped message
    TIMESTAMP=$(date +"%Y-%m-%d %H:%M:%S")
    git commit -m "Auto-commit: $TIMESTAMP"
    
    # Push changes to GitHub
    # (assumes main branch and saved credentials)
    git push
    
    echo "Successfully pushed at $TIMESTAMP"
else
    echo "No changes detected. Working tree clean."
fi
