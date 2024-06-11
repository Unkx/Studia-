document.addEventListener("DOMContentLoaded", function () {
    // Fetch tasks from the server on page load
    fetchTasks();
});

const selectedTaskIds = new Set(); // Set to store selected task IDs

async function addTask() {
    const taskInput = document.getElementById("taskInput");
    const task = taskInput.value.trim();

    if (task !== "") {
        try {
            // Send the task to the server
            const response = await fetch('http://localhost:3300/addTask', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ task }),
            });

            if (!response.ok) {
                throw new Error(`Failed to add task: ${response.statusText}`);
            }

            // Update the task list
            await fetchTasks();
            taskInput.value = "";
        } catch (error) {
            console.error('Error adding task:', error.message);
        }
    }
}

async function fetchTasks() {
    // Fetch tasks from the server
    fetch('http://localhost:3300/getTasks')
        .then(response => response.json())
        .then(data => {
            // Update the task list
            const taskList = document.getElementById("taskList");
            taskList.innerHTML = "";
            data.forEach(task => {
                const li = document.createElement("li");
                li.textContent = task.task;
                taskList.appendChild(li);
            });
        });
}

async function deleteTask() {
    const taskIdInput = document.getElementById("taskIdInput");
    const task = taskIdInput.value.trim();

    if (task !== "") {
        try {
            // Send the task ID to the server
            const response = await fetch('http://localhost:3300/deleteTask', {
                method: 'DELETE',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ task: task }),
            });

            if (!response.ok) {
                throw new Error(`Failed to delete task: ${response.statusText}`);
            }
            
            // Update the task list
            await fetchTasks();
            taskIdInput.value = "";
        } catch (error) {
            console.error('Error deleting task:', error.message);
        }
    }
}


function toggleTaskSelection(taskId) {
    if (selectedTaskIds.has(taskId)) {
        selectedTaskIds.delete(taskId);
    } else {
        selectedTaskIds.add(taskId);
    }
}

