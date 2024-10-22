import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';


const Home = () => {
    const [blogs, setBlogs] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch('https://localhost:7236/api/Blogs')
            .then((response) => response.json())
            .then((data) => {
                setBlogs(data);
                setIsLoading(false);
            })
            .catch((error) => {
                console.error('Error fetching blogs:', error);
                setError(error);
                setIsLoading(false);
            });
    }, []);

    const handleDelete = (blogId) => {
        fetch(`https://localhost:7236/api/Blogs/${blogId}`, {
            method: 'DELETE',
        })
            .then(() => {
                setBlogs(blogs.filter((blog) => blog.Id !== blogId));
            })
            .catch((error) => {
                console.error('Error deleting blog:', error);
            });
    };

    if (isLoading) return <div>Loading...</div>;
    if (error) return <div>Error: {error.message}</div>;

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
                                <a className="nav-link border-success" href="/Create"><button className="btn btn-outline-success"><i class="bi bi-plus-square"></i> Create</button></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <div className="container mt-5">
                <h1 className="text-light">Discover Amazing Blogs</h1><br/>
                <div className="row">
                    {blogs.map((blog) => (
                        <div key={blog.Id} className="col-md-4 mb-4">
                            <div className="card bg-black  border-info mb-3 rounded text-light d-flex" >
                                <div className="card-header ">
                                    <Link to={`/blogs/${blog.Id}`} className="text-decoration-none text-light">
                                        <h5 className="card-title">{blog.Title}<hr/></h5>
                                    </Link>
                                </div>
                                <div className="card-body">
                                    <p className="card-text" style={{ maxHeight: "3em", overflow: "hidden" }}> {blog.Description}</p>....<hr/>
                                   <div className="d-flex justify-content-around mt-3">
                                   <button className="btn btn-outline-danger " onClick={() => handleDelete(blog.Id)}><i className="bi bi-x-circle-fill"></i> Delete</button>
                                   <Link to={`/blogs/${blog.Id}`}><button className="btn btn-outline-info"><i className="bi bi-book"></i> Read</button></Link> 
                                   </div>
                                </div>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
};

export default Home;
