const { createApp, ref } = Vue;

        createApp({
            setup() {
                const formData = ref({
                    username: '',
                    password: ''
                });

                const handleSubmit = () => {
                    axios.post('your-server-endpoint', formData.value,
                    {
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })
                    
                        .then(response => {
                            console.log(response.data);
                        })
                        .catch(error => {
                            console.error('Error:', error);
                        });
                };

                return { formData, handleSubmit };
            }
        }).mount('#app');