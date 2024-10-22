import React, { useState } from 'react';
import { Link } from 'react-router-dom';

function NewBlog(){
    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');

    const send = () => {
        fetch('https://localhost:7236/api/Blogs', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                Title: title,
                Description: description,
            }),
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data);
                window.location.href = '/';
            })
            .catch((error) => {
                console.error('Error:', error);
            });
    };

    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-dark bg-black">
                <div className="container">
                    <a className="navbar-brand" href="/">Blogs Website</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav ms-auto">
                            <li className="nav-item">
                                <a className="nav-link" href="/"><button className="btn btn-outline-info"><i class="bi bi-house"></i></button></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <div className="mx-auto mt-5  border-info " style={{ maxWidth: '500px' }}>
                <div className="text-light ">
                    <h1 className=" text-center mb-4 text-light ">Create a Blog</h1>
                    <form>
                        <fieldset>
                            <div className="mb-3">
                                <label htmlFor="title" className="form-label"><i className="bi bi-pencil-square"></i> Title</label>
                                <input
                                    type="text"
                                    className="form-control"
                                    id="title"
                                    value={title}
                                    onChange={(e) => setTitle(e.target.value)}
                                />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="description" className="form-label"><i className="bi bi-card-text"></i> Description</label>
                                <textarea
                                    className="form-control"
                                    id="description"
                                    value={description}
                                    onChange={(e) => setDescription(e.target.value)}
                                ></textarea>
                            </div>
                            <div className='d-flex justify-content-around mt-3'>
                                <button type="button" className="btn btn-outline-success" onClick={send}>Submit</button>
                                <Link className="nav-link" to="/"><button type="button" className="btn btn-outline-light">Back to Home</button></Link>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
    );
};

export default NewBlog;
