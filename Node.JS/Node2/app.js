const express = require('express');
const bodyParser = require('body-parser');
const mysql = require('mysql2');


const app = express();
const port = 3300;
const cors = require('cors');


app.use(cors());
// MySQL connection
const connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'root',
    database: 'todo_list',
    port: 3308
});

connection.connect();

// Express setup
app.use(bodyParser.json());

// Endpoint to add a task
app.post('/addTask', (req, res) => {
    const { task } = req.body;

    // Insert the task into the database
    connection.query('INSERT INTO tasks (task) VALUES (?)', [task], (error, results) => {
        if (error) throw error;
        res.json({ success: true });
    });
});

// Endpoint to get all tasks
app.get('/getTasks', (req, res) => {
    // Fetch all tasks from the database
    connection.query('SELECT * FROM tasks', (error, results) => {
        if (error) throw error;
        res.json(results);
    });
});
// Express setup
app.use(bodyParser.json());

// Endpoint to delete a task
app.delete('/deleteTask', (req, res) => {
    const { task } = req.body;

    // Delete the task from the database
    connection.query('DELETE FROM tasks WHERE task = ?', [task], (error, results) => {
        if (error) {
            res.status(500).json({ success: false, message: 'Failed to delete task.' });
        } else {
            if (results.affectedRows > 0) {
                res.json({ success: true, message: 'Task deleted successfully.' });
            } else {
                res.json({ success: false, message: 'Task not found.' });
            }
        }
    });
});

// Start the server
app.listen(port, () => {
    console.log(`Server is running on port ${port}`);
});


