import Modal from 'react-modal';
import { useState } from 'react';
import axios from 'axios';
import config from '../../config';

import './blog-modal.styles.scss';

function BlogModal({ isOpen, onClose }) {
  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');

  const handleSubmit = async () => {
    try {
      await axios.post(
        'http://localhost:5267/api/Blogs',
        {
          title,
          description,
        },
        config
      );
    } catch (err) {
      console.log('Error while posting to the database.');
    }
  };

  return (
    <Modal
      isOpen={isOpen}
      onClose={onClose}
      className='modal-container'
      shouldCloseOnOverlayClick={true}
      shouldCloseOnEsc={true}
      ariaHideApp={false}
    >
      <h2>Create New Blog</h2>
      <form>
        <div>
          <label htmlFor='title'>Title: </label>
          <input id='title' type='text' value={title} onChange={e => setTitle(e.target.value)} />
        </div>

        <div>
          <label htmlFor='title'>Description: </label>
          <textarea value={description} onChange={e => setDescription(e.target.value)} />
        </div>

        <button onClick={handleSubmit}>Save</button>
      </form>
    </Modal>
  );
}

export default BlogModal;
