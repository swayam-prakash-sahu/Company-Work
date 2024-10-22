import { lazy, Suspense } from 'react';
import { useEffect, useState } from 'react';
import axios from 'axios';
import RingLoader from 'react-spinners/RingLoader';

import config from '../config';
import './home.styles.scss';

const BlogModal = lazy(() => import('../components/blog-modal/blog-modal.component'));
const BlogCard = lazy(() => import('../components/blog-card/blog-card.component'));

export default function Home() {
  const [blogsArr, setBlogsArr] = useState([]);
  const [modalIsOpen, setModalIsOpen] = useState(false);

  const openModal = () => setModalIsOpen(true);
  const closeModal = () => setModalIsOpen(false);

  useEffect(() => {
    const fetchAsync = async () => {
      try {
        const response = await axios.get('http://localhost:5267/api/Blogs', config);
        setBlogsArr([...response.data]);
      } catch (err) {
        console.log('Error occured when fetching blogs');
      }
    };

    fetchAsync();
  }, [blogsArr]);

  return (
    <Suspense fallback={<RingLoader color='rgb(219, 111, 249)' size={300} />}>
      <div className='home-container'>
        <header>
          <h1>Writedown</h1>

          <div className='create-blog'>
            <p>Read. Write. Explore</p>

            <button onClick={openModal}>Create New Blog</button>
            <BlogModal isOpen={modalIsOpen} onClose={closeModal}></BlogModal>
          </div>
        </header>
        <main className='blogs-container'>
          {blogsArr.map(blog => (
            <BlogCard
              key={blog.id}
              id={blog.id}
              title={blog.title}
              description={blog.description}
            />
          ))}
        </main>
      </div>
    </Suspense>
  );
}
